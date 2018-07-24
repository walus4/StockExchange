using Microsoft.EntityFrameworkCore.Migrations;

namespace StockExchange.Web.Data.Migrations
{
    public partial class UsercurenceFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "UserCurrecnies",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Amount",
                table: "UserCurrecnies",
                nullable: false,
                oldClrType: typeof(decimal));
        }
    }
}
