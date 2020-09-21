using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _4Point1_EF.Migrations
{
    public partial class ShelvesToShelf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "shelves");

            migrationBuilder.CreateTable(
                name: "shelf",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(10)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shelf", x => x.id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "shelf");

            migrationBuilder.CreateTable(
                name: "shelves",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(10)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shelves", x => x.id);
                });

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
    }
}
