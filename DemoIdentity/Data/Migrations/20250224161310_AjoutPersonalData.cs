using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoIdentity.Data.Migrations
{
    /// <inheritdoc />
    public partial class AjoutPersonalData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AdresseCodePostal",
                table: "AspNetUsers",
                type: "nvarchar(5)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdresseRue",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdresseVille",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdresseCodePostal",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AdresseRue",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AdresseVille",
                table: "AspNetUsers");
        }
    }
}
