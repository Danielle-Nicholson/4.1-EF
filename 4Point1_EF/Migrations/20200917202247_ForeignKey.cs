using Microsoft.EntityFrameworkCore.Migrations;

namespace _4Point1_EF.Migrations
{
    public partial class ForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "manufacturer",
                table: "code_first_car");

            migrationBuilder.AddColumn<int>(
                name: "manufacturer_id",
                table: "code_first_car",
                type: "int(10)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "manufacturer_id", "model", "odometer" },
                values: new object[] { 1, "Durango", 68780 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Corvette", 157469, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Durango", 200640, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "manufacturer_id", "odometer", "trim_level" },
                values: new object[] { 1, 76546, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Fusion", 23885, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "manufacturer_id", "model", "odometer" },
                values: new object[] { 1, "Corvette", 176177 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "manufacturer_id", "model", "odometer" },
                values: new object[] { 1, "Corvette", 178334 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "manufacturer_id", "model", "odometer" },
                values: new object[] { 1, "Durango", 151936 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "manufacturer_id", "odometer", "trim_level" },
                values: new object[] { 1, 9208, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Corvette", 292556, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "manufacturer_id", "odometer", "trim_level" },
                values: new object[] { 1, 150115, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "manufacturer_id", "odometer", "trim_level" },
                values: new object[] { 1, 147126, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "manufacturer_id", "model", "odometer" },
                values: new object[] { 1, "Fusion", 118191 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "manufacturer_id", "odometer", "trim_level" },
                values: new object[] { 1, 298039, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "manufacturer_id", "odometer", "trim_level" },
                values: new object[] { 1, 114493, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Fusion", 94936, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Fusion", 250588, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "manufacturer_id", "odometer", "trim_level" },
                values: new object[] { 1, 206185, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "manufacturer_id", "model", "odometer" },
                values: new object[] { 1, "Durango", 243170 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Fusion", 233766, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "manufacturer_id", "model", "odometer" },
                values: new object[] { 1, "Durango", 51099 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Fusion", 108224, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "manufacturer_id", "odometer", "trim_level" },
                values: new object[] { 1, 68722, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Durango", 153279, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "manufacturer_id", "model", "odometer" },
                values: new object[] { 1, "Corvette", 298296 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "manufacturer_id", "model", "odometer" },
                values: new object[] { 1, "Durango", 87283 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Corvette", 20011, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "manufacturer_id", "odometer", "trim_level" },
                values: new object[] { 1, 194836, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Corvette", 299207, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "manufacturer_id", "odometer", "trim_level" },
                values: new object[] { 1, 94801, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Fusion", 246260, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "manufacturer_id", "model", "odometer" },
                values: new object[] { 1, "Durango", 87601 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Fusion", 169090, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "manufacturer_id", "model", "odometer" },
                values: new object[] { 1, "Corvette", 211362 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "manufacturer_id", "odometer", "trim_level" },
                values: new object[] { 1, 18509, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Corvette", 79624, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "manufacturer_id", "model", "odometer" },
                values: new object[] { 1, "Fusion", 201415 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Durango", 12418, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Fusion", 25535, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "manufacturer_id", "odometer" },
                values: new object[] { 1, 15715 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Durango", 62057, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Fusion", 3889, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "manufacturer_id", "odometer" },
                values: new object[] { 1, 242748 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "manufacturer_id", "model", "odometer" },
                values: new object[] { 1, "Fusion", 154394 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Fusion", 174340, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Durango", 259774, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "manufacturer_id", "model", "odometer" },
                values: new object[] { 1, "Durango", 18259 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Fusion", 150687, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "manufacturer_id", "model", "odometer", "trim_level" },
                values: new object[] { 1, "Durango", 164550, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "manufacturer_id", "odometer" },
                values: new object[] { 1, 24149 });

            migrationBuilder.CreateIndex(
                name: "FK_CodeFirstCar_Manufacturer",
                table: "code_first_car",
                column: "manufacturer_id");

            migrationBuilder.AddForeignKey(
                name: "FK_CodeFirstCar_Manufacturer",
                table: "code_first_car",
                column: "manufacturer_id",
                principalTable: "manufacturer",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CodeFirstCar_Manufacturer",
                table: "code_first_car");

            migrationBuilder.DropIndex(
                name: "FK_CodeFirstCar_Manufacturer",
                table: "code_first_car");

            migrationBuilder.DropColumn(
                name: "manufacturer_id",
                table: "code_first_car");

            migrationBuilder.AddColumn<string>(
                name: "manufacturer",
                table: "code_first_car",
                type: "varchar(30)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("MySql:Collation", "utf8mb4_general_ci");

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
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Dodge", "Corvette", 177150, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Chevrolet", 7309, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Chevrolet", "Corvette", 124589, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Dodge", "Fusion", 58560 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Dodge", "Durango", 186997 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Chevrolet", "Fusion", 266006 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Ford", 214519, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Dodge", "Durango", 205373, "R/T" });

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
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Dodge", 63684, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Chevrolet", "Corvette", 197659 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Ford", 141696, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Dodge", 249184, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Chevrolet", "Corvette", 167702, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Chevrolet", "Durango", 192133, "Awesome" });

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
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Ford", "Corvette", 224903 });

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
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Ford", "Corvette", 15369 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Dodge", "Durango", 119101, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Ford", 261247, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Ford", "Fusion", 188169, "R/T" });

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
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Dodge", "Fusion", 281731, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Ford", 88611, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Ford", "Fusion", 236263, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Ford", 149519, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Dodge", "Corvette", 131963, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Ford", "Fusion", 6527 });

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
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Chevrolet", "Fusion", 11040 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "manufacturer", "odometer", "trim_level" },
                values: new object[] { "Chevrolet", 163166, "Awesome" });

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
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Chevrolet", "Corvette", 276248 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Ford", "Fusion", 278312, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Dodge", "Durango", 22896, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "manufacturer", "odometer" },
                values: new object[] { "Chevrolet", 175270 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Ford", "Fusion", 214536, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Ford", "Durango", 267356, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "manufacturer", "odometer" },
                values: new object[] { "Ford", 211301 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Chevrolet", "Durango", 177588 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Ford", "Corvette", 191347, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Dodge", "Fusion", 174229, "High Country" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "manufacturer", "model", "odometer" },
                values: new object[] { "Chevrolet", "Corvette", 269640 });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Dodge", "Corvette", 197301, "Awesome" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "manufacturer", "model", "odometer", "trim_level" },
                values: new object[] { "Dodge", "Corvette", 202834, "R/T" });

            migrationBuilder.UpdateData(
                table: "code_first_car",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "manufacturer", "odometer" },
                values: new object[] { "Dodge", 171229 });
        }
    }
}
