using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _4Point1_EF.Migrations
{
    public partial class ShelfMaterial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<int>(
                name: "material_id",
                table: "shelf",
                type: "int(10)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "shelfmaterial",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(10)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(25)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shelfmaterial", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "FK_Shelf_ShelfMaterial",
                table: "shelf",
                column: "material_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Shelf_ShelfMaterial",
                table: "shelf",
                column: "material_id",
                principalTable: "shelfmaterial",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shelf_ShelfMaterial",
                table: "shelf");

            migrationBuilder.DropTable(
                name: "shelfmaterial");

            migrationBuilder.DropIndex(
                name: "FK_Shelf_ShelfMaterial",
                table: "shelf");

            migrationBuilder.DropColumn(
                name: "material_id",
                table: "shelf");

            migrationBuilder.InsertData(
                table: "shelf",
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
    }
}
