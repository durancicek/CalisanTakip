using Microsoft.EntityFrameworkCore.Migrations;

namespace CalisanTakipDAL.Migrations
{
    public partial class AddCalisanTipiAddColumIsActive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "IzinTipis",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "IzinTipis");
        }
    }
}
