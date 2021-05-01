using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NoteCapture.Models;
using Microsoft.AspNetCore.Http;
using NoteCapture.Data;

namespace NoteCapture.Controllers
{
    public class AuthController : Controller
    {
        private readonly ApplicationDbContext _context;
        private UserManager<AppUser> _userManager { get; set; }
        private SignInManager<AppUser> _signInManager { get; set; }

        public AuthController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(IFormCollection fc)
        {
            // Get username and password variables
            string username = fc["UserName"];
            string password = fc["Password"];

            // Check if user exists
            var user = await _userManager.FindByNameAsync(username);
            if (user == null)
            {
                // Need to return an error message here.
                return View();
            }

            // If user does exist, then attempt to sign in the user
            var result = await _signInManager.PasswordSignInAsync(user, password, false, false);

            // If the sign in succeeds, redirect user to home page
            if (result.Succeeded == true)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                // Need to show an error message here saying that sign-in failed.
                return View();
            }
        }

        public IActionResult Register()
        {
            UserRegistrationModel userRegModel = new UserRegistrationModel();
            return View(userRegModel);
        }

        [HttpPost]
        public async Task<IActionResult> Register([Bind("ID,UserName,FirstName,LastName,EmailAddress,Password1,Password2")] UserRegistrationModel userRegModel)
        {

            // The controller checks to make sure a user with this username doesn't already exist.
            // If another user does already have this username, an error message is returned and the user is
            // returned to the registration page.
            var userName = userRegModel.UserName;
            var user = await _userManager.FindByNameAsync(userName);
            if (user != null)
            {
                // Need to return an error message here inside the form.
                return View();
            }

            // The controller checks to make sure that the two passwords enter match.
            var password1 = userRegModel.Password1;
            var password2 = userRegModel.Password2;
            bool passwordMatch = password1 == password2;
            if (!passwordMatch)
            {
                // Need to return error message saying passwords don't match. In fact, this probably should
                // be handled at the form level.
                return View(userRegModel);
            }

            var newPassword = password1;

            // Now that the controller has confirmed that no user currently exists with this username,
            // it creates a new AppUser object with the parameters provided.
            var newUser = new AppUser
            {
                UserName = userRegModel.UserName,
                FirstName = userRegModel.FirstName,
                LastName = userRegModel.LastName,
                Email = userRegModel.EmailAddress
            };

            // The controller calls CreateAsync() from the user manager using the new AppUser object and the
            // provided password. If the method failes for some reason, the errors are logged and the user is
            // returned to the registration page.
            var result = await _userManager.CreateAsync(newUser, newPassword);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }

                return View(userRegModel);
            }

            /*
            // Now that the user is registered and their account has been created, the application sends an
            // email confirmation token to the address on file.
            var emailToken = await _userManager.GenerateEmailConfirmationTokenAsync(newUser);
            var confirmationLink = Url.Action(nameof(ConfirmEmail), "Auth", new { emailToken, email = newUser.Email }, Request.Scheme);
            */

            // Finally, return the user to the login page.
            return RedirectToAction("Login");
        }

        public async Task<IActionResult> ConfirmEmail(string token, string emailAddress)
        {
            // Get the user associated with the email address
            var user = await _userManager.FindByEmailAsync(emailAddress);
            if (user == null)
            {
                return View("Error");
            }

            var result = await _userManager.ConfirmEmailAsync(user, token);

            return View(result.Succeeded ? nameof(ConfirmEmail) : "Error");
        }

        public IActionResult SuccessRegistration()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
