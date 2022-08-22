using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AToDo.Api.Migrations
{
    public partial class AjustmentRefreshToken : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpiryDatee",
                table: "RefreshTokens");

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpiryDate",
                table: "RefreshTokens",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpiryDate",
                table: "RefreshTokens");

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpiryDatee",
                table: "RefreshTokens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
