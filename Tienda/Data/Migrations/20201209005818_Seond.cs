using Microsoft.EntityFrameworkCore.Migrations;

namespace Tienda.Data.Migrations
{
    public partial class Seond : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagenUrl",
                table: "Service");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Service",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LongDesc",
                table: "Service",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Service");

            migrationBuilder.DropColumn(
                name: "LongDesc",
                table: "Service");

            migrationBuilder.AddColumn<string>(
                name: "ImagenUrl",
                table: "Service",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
