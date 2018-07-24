using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace StockExchange.Web.Data.Migrations
{
    public partial class usercurrency : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
