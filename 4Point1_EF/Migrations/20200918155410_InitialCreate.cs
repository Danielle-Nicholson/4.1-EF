using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _4Point1_EF.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            // I removed the tables we made with SQL because this version of EF didn't track the import in a migration, so it thought all the models were new tables.

            migrationBuilder.CreateTable(
                name: "emailaddress",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int(10)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(type: "varchar(30)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_general_ci"),
                    PersonID = table.Column<int>(type: "int(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_emailaddress", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EmailAddress_Person",
                        column: x => x.PersonID,
                        principalTable: "person",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            
            migrationBuilder.InsertData(
                table: "emailaddress",
                columns: new[] { "ID", "Email", "PersonID" },
                values: new object[,]
                {
                    { 1, "johndoe@email.com", 1 },
                    { 2, "janedoe@email.com", 2 },
                    { 3, "tommywiseau@theroom.com", 3 },
                    { 4, "jimmysmith@email.com", 4 },
                    { 5, "sallysmith@email.com", 5 }
                });

            migrationBuilder.CreateIndex(
                name: "FK_EmailAddress_Person",
                table: "emailaddress",
                column: "PersonID");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "emailaddress");

        }
    }
}
