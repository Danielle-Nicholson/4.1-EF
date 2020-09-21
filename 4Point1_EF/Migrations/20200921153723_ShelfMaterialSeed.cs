using Microsoft.EntityFrameworkCore.Migrations;

namespace _4Point1_EF.Migrations
{
    public partial class ShelfMaterialSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "shelfmaterial",
                columns: new[] { "id", "name" },
                values: new object[] { -1, "Wood" });

            migrationBuilder.InsertData(
                table: "shelfmaterial",
                columns: new[] { "id", "name" },
                values: new object[] { -2, "Steel" });

            migrationBuilder.InsertData(
                table: "shelfmaterial",
                columns: new[] { "id", "name" },
                values: new object[] { -3, "Plastic" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "shelfmaterial",
                keyColumn: "id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "shelfmaterial",
                keyColumn: "id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "shelfmaterial",
                keyColumn: "id",
                keyValue: -1);
        }
    }
}
