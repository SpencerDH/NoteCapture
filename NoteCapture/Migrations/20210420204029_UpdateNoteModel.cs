using Microsoft.EntityFrameworkCore.Migrations;

namespace NoteCapture.Migrations
{
    public partial class UpdateNoteModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NoteTitle",
                table: "Notes",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NoteTitle",
                table: "Notes");
        }
    }
}
