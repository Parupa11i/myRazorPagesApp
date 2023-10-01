using Microsoft.EntityFrameworkCore.Migrations;

namespace myRazorPagesApp.Migrations
{
    public partial class AddISBNToBookList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "Book",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "author",
                table: "Book",
                newName: "Author");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Book",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "ISBN",
                table: "Book",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ISBN",
                table: "Book");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Book",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Author",
                table: "Book",
                newName: "author");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Book",
                newName: "id");
        }
    }
}
