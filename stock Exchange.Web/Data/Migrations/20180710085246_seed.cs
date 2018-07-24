using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StockExchange.Web.Data.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StockActionses",
                table: "StockActionses");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "StockActionses");

            migrationBuilder.AlterColumn<string>(
                name: "ActionCode",
                table: "StockActionses",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_StockActionses",
                table: "StockActionses",
                column: "ActionCode");

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Code", "Name", "Unit" },
                values: new object[,]
                {
                    { "FP", "Future Processing", 1 },
                    { "FPL", "FP Lab", 100 },
                    { "PGB", "Progress Bar", 1 },
                    { "FPC", "FP Coin", 50 },
                    { "FPA", "FP Adventure", 50 },
                    { "DL24", "Deadline 24", 100 }
                });

            migrationBuilder.InsertData(
                table: "StockActionses",
                columns: new[] { "ActionCode", "Amount" },
                values: new object[] { "FP", 1000 });

            migrationBuilder.AddForeignKey(
                name: "FK_StockActionses_Companies_ActionCode",
                table: "StockActionses",
                column: "ActionCode",
                principalTable: "Companies",
                principalColumn: "Code",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StockActionses_Companies_ActionCode",
                table: "StockActionses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StockActionses",
                table: "StockActionses");

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Code",
                keyValue: "DL24");

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Code",
                keyValue: "FPA");

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Code",
                keyValue: "FPC");

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Code",
                keyValue: "FPL");

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Code",
                keyValue: "PGB");

            migrationBuilder.DeleteData(
                table: "StockActionses",
                keyColumn: "ActionCode",
                keyValue: "FP");

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Code",
                keyValue: "FP");

            migrationBuilder.AlterColumn<string>(
                name: "ActionCode",
                table: "StockActionses",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "StockActionses",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_StockActionses",
                table: "StockActionses",
                column: "Id");
        }
    }
}
