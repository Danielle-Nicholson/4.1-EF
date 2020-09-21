using Microsoft.EntityFrameworkCore.Migrations;

namespace _4Point1_EF.Migrations
{
    public partial class ShelfSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "shelf",
                columns: new[] { "id", "material_id", "name" },
                values: new object[,]
                {
                    { -1, -2, "Tools Shelf" },
                    { -2, -3, "Electronics Shelf" },
                    { -3, -1, "Food Shelf" },
                    { -4, -1, "Dishes Shelf" },
                    { -5, -1, "Book Shelf" },
                    { -6, -1, "Plant Shelf" },
                    { -7, -1, "Cactus Shelf" },
                    { -8, -3, "Pet Food Shelf" },
                    { -9, -3, "Lego Shelf" },
                    { -10, -1, "Magazine Shelf" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "shelf",
                keyColumn: "id",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "shelf",
                keyColumn: "id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "shelf",
                keyColumn: "id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "shelf",
                keyColumn: "id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "shelf",
                keyColumn: "id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "shelf",
                keyColumn: "id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "shelf",
                keyColumn: "id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "shelf",
                keyColumn: "id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "shelf",
                keyColumn: "id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "shelf",
                keyColumn: "id",
                keyValue: -1);
        }
    }
}
