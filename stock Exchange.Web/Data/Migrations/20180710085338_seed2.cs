using Microsoft.EntityFrameworkCore.Migrations;

namespace StockExchange.Web.Data.Migrations
{
    public partial class seed2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "StockActionses",
                columns: new[] { "ActionCode", "Amount" },
                values: new object[,]
                {
                    { "FPL", 10000 },
                    { "PGB", 1000000 },
                    { "FPC", 50000 },
                    { "FPA", 50000000 },
                    { "DL24", 1000000000 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StockActionses",
                keyColumn: "ActionCode",
                keyValue: "DL24");

            migrationBuilder.DeleteData(
                table: "StockActionses",
                keyColumn: "ActionCode",
                keyValue: "FPA");

            migrationBuilder.DeleteData(
                table: "StockActionses",
                keyColumn: "ActionCode",
                keyValue: "FPC");

            migrationBuilder.DeleteData(
                table: "StockActionses",
                keyColumn: "ActionCode",
                keyValue: "FPL");

            migrationBuilder.DeleteData(
                table: "StockActionses",
                keyColumn: "ActionCode",
                keyValue: "PGB");
        }
    }
}
