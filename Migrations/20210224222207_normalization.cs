using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment_Amazon.Migrations
{
    public partial class normalization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "category",
                table: "books",
                newName: "category2");

            migrationBuilder.RenameColumn(
                name: "author",
                table: "books",
                newName: "category1");

            migrationBuilder.AddColumn<string>(
                name: "authorFirst",
                table: "books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "authorLast",
                table: "books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "numPages",
                table: "books",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "authorFirst",
                table: "books");

            migrationBuilder.DropColumn(
                name: "authorLast",
                table: "books");

            migrationBuilder.DropColumn(
                name: "numPages",
                table: "books");

            migrationBuilder.RenameColumn(
                name: "category2",
                table: "books",
                newName: "category");

            migrationBuilder.RenameColumn(
                name: "category1",
                table: "books",
                newName: "author");
        }
    }
}
