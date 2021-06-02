#pragma checksum "C:\Users\spenc\WebDev\NoteCapture\NoteCapture\Views\Notes\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56af324a5e125219807e7d9a89663056f8b29ac6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Notes_Search), @"mvc.1.0.view", @"/Views/Notes/Search.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\spenc\WebDev\NoteCapture\NoteCapture\Views\_ViewImports.cshtml"
using NoteCapture;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\spenc\WebDev\NoteCapture\NoteCapture\Views\_ViewImports.cshtml"
using NoteCapture.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56af324a5e125219807e7d9a89663056f8b29ac6", @"/Views/Notes/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efe370d427852aa7ad47e69f0386dac02e4549a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Notes_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<NoteCapture.Models.Note>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Notes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\spenc\WebDev\NoteCapture\NoteCapture\Views\Notes\Search.cshtml"
  
    Layout = "/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-6 col1"">
            <nav class=""navbar navbar-light bg-light"">
                <ul class=""navbar-nav mr-auto"">
                    <li>Search results</li>
                    <li>n notes found</li>
                    <li class=""nav-item active"">
                        <a class=""nav-link"" href=""#"">Filter</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""#"">Sort</a>
                    </li>
                </ul>
            </nav>

");
#nullable restore
#line 23 "C:\Users\spenc\WebDev\NoteCapture\NoteCapture\Views\Notes\Search.cshtml"
             if (Model.Count > 0)
            {
                foreach (var note in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card note-card card-click\"");
            BeginWriteAttribute("id", " id=\"", 869, "\"", 882, 1);
#nullable restore
#line 27 "C:\Users\spenc\WebDev\NoteCapture\NoteCapture\Views\Notes\Search.cshtml"
WriteAttributeValue("", 874, note.ID, 874, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"card-header\">");
#nullable restore
#line 28 "C:\Users\spenc\WebDev\NoteCapture\NoteCapture\Views\Notes\Search.cshtml"
                                            Write(note.NoteTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div class=\"card-body\">");
#nullable restore
#line 29 "C:\Users\spenc\WebDev\NoteCapture\NoteCapture\Views\Notes\Search.cshtml"
                                          Write(Html.Raw(note.NoteText));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n");
#nullable restore
#line 31 "C:\Users\spenc\WebDev\NoteCapture\NoteCapture\Views\Notes\Search.cshtml"
                }
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"empty-search-result\">No results found</p>\r\n");
#nullable restore
#line 36 "C:\Users\spenc\WebDev\NoteCapture\NoteCapture\Views\Notes\Search.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n        <div class=\"col-6 col2\">\r\n");
#nullable restore
#line 40 "C:\Users\spenc\WebDev\NoteCapture\NoteCapture\Views\Notes\Search.cshtml"
             if (Model.Count > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56af324a5e125219807e7d9a89663056f8b29ac67178", async() => {
                WriteLiteral(@"
                    <input type=""hidden"" id=""ID"" name=""ID"" />
                    <div class=""input-group form-group"">
                        <input class=""name-should-be-better"" id=""NoteTitle"" name=""NoteTitle"" type=""text"" placeholder=""Title"" />
                    </div>
                    <div class=""input-group form-group"">
                        <textarea id=""NoteText"" name=""NoteText"" rows=""20"" class=""form-control""></textarea>
                    </div>
                    <div class=""form-group"">
                        <input type=""submit"" class=""btn btn-primary"" value=""Submit"" />
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 54 "C:\Users\spenc\WebDev\NoteCapture\NoteCapture\Views\Notes\Search.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</div>



<script src=""https://cdn.tiny.cloud/1/sdhg5pggurg8ldhp6e6hdqx8eragpccy99awa61ejtm0tll8/tinymce/5/tinymce.min.js"" referrerpolicy=""origin""></script>
<script>
    $(document).ready(function () {
        $("".card-click"").click(function () {
            // Add a border to the card that's clicked
            $(""div.card"").css(""border"", ""0px"");
            $(this).css(""border"", ""1px solid black"");

            // Extract the content that needs to be passed into the edit form
            var noteTitle = $(this).children(""div.card-header"").text()
            var noteText = $(this).children(""div.card-body"").html();
            var noteID = $(this).attr(""id"");

            // Set the values in the edit form
            $(""#ID"").val(noteID);
            $(""#NoteTitle"").val(noteTitle);
            tinymce.activeEditor.setContent(noteText);
        });
    });
</script>
<script>
    tinymce.init({
        selector: 'textarea',
        plugins: 'a11ychecker ad");
            WriteLiteral(@"vcode casechange formatpainter linkchecker autolink lists checklist media mediaembed pageembed permanentpen powerpaste table advtable tinycomments tinymcespellchecker',
        toolbar: 'a11ycheck addcomment showcomments casechange checklist code formatpainter pageembed permanentpen table',
        toolbar_mode: 'floating',
        tinycomments_mode: 'embedded',
        tinycomments_author: 'Author name',
    });
</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<NoteCapture.Models.Note>> Html { get; private set; }
    }
}
#pragma warning restore 1591