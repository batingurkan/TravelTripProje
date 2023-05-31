using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelTripProje.Migrations
{
    public partial class deneme2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Blodid",
                table: "Yorumlars",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Blodid",
                table: "Yorumlars");
        }
    }
}
