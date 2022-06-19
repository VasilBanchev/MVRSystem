using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    public partial class EGNUniqueEveryWhere : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_DrivingLicenses_EGN",
                table: "DrivingLicenses",
                column: "EGN",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cards_EGN",
                table: "Cards",
                column: "EGN",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_DrivingLicenses_EGN",
                table: "DrivingLicenses");

            migrationBuilder.DropIndex(
                name: "IX_Cards_EGN",
                table: "Cards");
        }
    }
}
