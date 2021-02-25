using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment_Amazon.Migrations
{
    public partial class normalization2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "title",
                table: "books",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "publisher",
                table: "books",
                newName: "Publisher");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "books",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "numPages",
                table: "books",
                newName: "NumPages");

            migrationBuilder.RenameColumn(
                name: "isbn",
                table: "books",
                newName: "Isbn");

            migrationBuilder.RenameColumn(
                name: "category2",
                table: "books",
                newName: "Category2");

            migrationBuilder.RenameColumn(
                name: "category1",
                table: "books",
                newName: "Category1");

            migrationBuilder.RenameColumn(
                name: "authorLast",
                table: "books",
                newName: "AuthorLast");

            migrationBuilder.RenameColumn(
                name: "authorFirst",
                table: "books",
                newName: "AuthorFirst");

            migrationBuilder.RenameColumn(
                name: "bookId",
                table: "books",
                newName: "BookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "books",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Publisher",
                table: "books",
                newName: "publisher");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "books",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "NumPages",
                table: "books",
                newName: "numPages");

            migrationBuilder.RenameColumn(
                name: "Isbn",
                table: "books",
                newName: "isbn");

            migrationBuilder.RenameColumn(
                name: "Category2",
                table: "books",
                newName: "category2");

            migrationBuilder.RenameColumn(
                name: "Category1",
                table: "books",
                newName: "category1");

            migrationBuilder.RenameColumn(
                name: "AuthorLast",
                table: "books",
                newName: "authorLast");

            migrationBuilder.RenameColumn(
                name: "AuthorFirst",
                table: "books",
                newName: "authorFirst");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "books",
                newName: "bookId");
        }
    }
}
