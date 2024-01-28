using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreApi1.Migrations
{
    /// <inheritdoc />
    public partial class modify : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDt",
                table: "user");

            migrationBuilder.DropColumn(
                name: "DeletedDStatus",
                table: "user");

            migrationBuilder.DropColumn(
                name: "DeletedDt",
                table: "user");

            migrationBuilder.DropColumn(
                name: "ModifiedDt",
                table: "user");

            migrationBuilder.AddColumn<string>(
                name: "Hobby",
                table: "user",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SkillSet",
                table: "user",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hobby",
                table: "user");

            migrationBuilder.DropColumn(
                name: "SkillSet",
                table: "user");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDt",
                table: "user",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletedDStatus",
                table: "user",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDt",
                table: "user",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDt",
                table: "user",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
