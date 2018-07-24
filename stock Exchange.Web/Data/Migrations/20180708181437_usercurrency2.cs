using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace StockExchange.Web.Data.Migrations
{
    public partial class usercurrency2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_UserCurrecnies_UserCurrecnyId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_UserCurrecnyId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserCurrecnyId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserCurrecnies",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserCurrecnies_UserId",
                table: "UserCurrecnies",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_UserCurrecnies_AspNetUsers_UserId",
                table: "UserCurrecnies",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserCurrecnies_AspNetUsers_UserId",
                table: "UserCurrecnies");

            migrationBuilder.DropIndex(
                name: "IX_UserCurrecnies_UserId",
                table: "UserCurrecnies");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserCurrecnies",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserCurrecnyId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_UserCurrecnyId",
                table: "AspNetUsers",
                column: "UserCurrecnyId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_UserCurrecnies_UserCurrecnyId",
                table: "AspNetUsers",
                column: "UserCurrecnyId",
                principalTable: "UserCurrecnies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
