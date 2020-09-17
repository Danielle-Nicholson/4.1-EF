using Microsoft.EntityFrameworkCore.Migrations;

namespace _4Point1_EF.Migrations
{
    public partial class SeedDataRedo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "code_first_car",
                columns: new[] { "id", "colour", "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Black", "Mitsubishi", "Lancer", 40000, "Evolution" });

            migrationBuilder.InsertData(
                table: "code_first_car",
                columns: new[] { "id", "colour", "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { 2, "Red", "Honda", "Civic", 110000, "LX" });

            migrationBuilder.InsertData(
                table: "code_first_car",
                columns: new[] { "id", "colour", "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { 3, "Blue", "Dodge", "Stealth", 98500, "R/T TT" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
