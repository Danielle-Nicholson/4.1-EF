using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _4Point1_EF.Migrations
{
    public partial class ManufacturerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "manufacturer",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(10)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(30)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_general_ci"),
                    year_founded = table.Column<int>(type: "int(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_manufacturer", x => x.id);
                });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Dodge", "Corvette", 46854 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Dodge", "Durango", 287287, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Dodge", "Corvette", 177150 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Chevrolet", "Durango", 7309 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Chevrolet", 124589, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Dodge", "Fusion", 58560, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Dodge", 186997, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "manufacturer", "odometer" },
                values: new object[] { "Chevrolet", 266006 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Ford", "Durango", 214519 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Dodge", "Durango", 205373 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Ford", 258338, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Dodge", "Corvette", 63684, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "odometer", "trim_level" },
                values: new object[] { 197659, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Ford", "Durango", 141696, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Durango", 249184, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Corvette", 167702, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Chevrolet", 192133, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Chevrolet", 225288, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Ford", "Corvette", 224903, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Ford", "Corvette", 172390, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Ford", 15369, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Dodge", 119101, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Ford", "Fusion", 261247 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "odometer", "trim_level" },
                values: new object[] { 188169, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Ford", "Durango", 274066 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Dodge", "Fusion", 78686 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Dodge", 281731, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Ford", "Fusion", 88611 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Fusion", 236263, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "odometer", "trim_level" },
                values: new object[] { 149519, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "odometer", "trim_level" },
                values: new object[] { 131963, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Ford", 6527, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Dodge", "Corvette", 70641, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Chevrolet", 11040, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Chevrolet", "Corvette", 163166, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Dodge", "Fusion", 238158, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Chevrolet", "Corvette", 276248, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "manufacturer", "odometer" },
                values: new object[] { "Ford", 278312 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Dodge", "Durango", 22896 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Chevrolet", "Durango", 175270 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "model", "odometer" },
                values: new object[] { "Fusion", 214536 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Ford", 267356, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Ford", 211301, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Chevrolet", 177588, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "manufacturer", "odometer" },
                values: new object[] { "Ford", 191347 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "odometer", "trim_level" },
                values: new object[] { 174229, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "odometer", "trim_level" },
                values: new object[] { 269640, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Dodge", "Corvette", 197301 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "manufacturer", "odometer" },
                values: new object[] { "Dodge", 202834 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Dodge", "Fusion", 171229, "Awesome" });

            migrationBuilder.InsertData(
                table: "manufacturer",
                columns: new[] { "id", "name", "year_founded" },
                values: new object[,]
                {
                    { 7, "Mitsubishi", null },
                    { 6, "Honda", 1946 },
                    { 5, "Toyota", 1937 },
                    { 4, "Dodge", null },
                    { 3, "Tesla", null },
                    { 2, "Ford", 1903 },
                    { 8, "Nissan", null },
                    { 1, "Chevrolet", 1911 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "manufacturer");

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Chevrolet", "Fusion", 199381 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Chevrolet", "Fusion", 27320, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Ford", "Durango", 48696 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Ford", "Fusion", 262923 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Ford", 189920, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Chevrolet", "Corvette", 30512, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Ford", 216400, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "manufacturer", "odometer" },
                values: new object[] { "Dodge", 234644 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Dodge", "Fusion", 258688 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Ford", "Fusion", 243988 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Chevrolet", 83714, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Ford", "Durango", 220189, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "odometer", "trim_level" },
                values: new object[] { 192930, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Dodge", "Corvette", 289448, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Fusion", 251240, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Durango", 280350, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Dodge", 255740, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Dodge", 287963, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Dodge", "Durango", 168189, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Chevrolet", "Durango", 87086, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Chevrolet", 169562, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Chevrolet", 135354, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Chevrolet", "Corvette", 24200 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "odometer", "trim_level" },
                values: new object[] { 190756, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Chevrolet", "Corvette", 118234 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Ford", "Durango", 294750 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Chevrolet", 19257, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Dodge", "Corvette", 1277 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "model", "odometer", "trim_level" },
                values: new object[] { "Durango", 277687, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "odometer", "trim_level" },
                values: new object[] { 254224, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "odometer", "trim_level" },
                values: new object[] { 71577, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Dodge", 191825, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Ford", "Fusion", 80711, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Dodge", 242729, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Ford", "Durango", 61323, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Chevrolet", "Corvette", 85819, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Dodge", "Durango", 76140, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "manufacturer", "odometer" },
                values: new object[] { "Chevrolet", 79770 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Chevrolet", "Corvette", 203786 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Ford", "Fusion", 53775 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "model", "odometer" },
                values: new object[] { "Durango", 161510 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Dodge", 298194, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Chevrolet", 34187, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Dodge", 69880, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "manufacturer", "odometer" },
                values: new object[] { "Chevrolet", 17577 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "odometer", "trim_level" },
                values: new object[] { 241688, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "odometer", "trim_level" },
                values: new object[] { 101030, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Ford", "Fusion", 262649 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "manufacturer", "odometer" },
                values: new object[] { "Chevrolet", 221038 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Ford", "Durango", 60121, "R/T" });
        }
    }
}
