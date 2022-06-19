using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    public partial class EGNUnique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Visas");

            migrationBuilder.CreateIndex(
                name: "IX_Passports_EGN",
                table: "Passports",
                column: "EGN",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Passports_EGN",
                table: "Passports");

            migrationBuilder.CreateTable(
                name: "Visas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CreationDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Entries = table.Column<int>(type: "int", nullable: false),
                    ExpireDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Visa = table.Column<string>(type: "nvarchar(9)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Visas_Passports_Visa",
                        column: x => x.Visa,
                        principalTable: "Passports",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Visas_Visa",
                table: "Visas",
                column: "Visa");
        }
    }
}
