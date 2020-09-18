using Microsoft.EntityFrameworkCore.Migrations;

namespace _4Point1_EF.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "shelves",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { -1, "Tools Shelf" },
                    { -2, "Electronics Shelf" },
                    { -3, "Food Shelf" },
                    { -4, "Dishes Shelf" },
                    { -5, "Book Shelf" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "shelves",
                keyColumn: "id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "shelves",
                keyColumn: "id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "shelves",
                keyColumn: "id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "shelves",
                keyColumn: "id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "shelves",
                keyColumn: "id",
                keyValue: -1);
        }
    }
}
