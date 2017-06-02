using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NETCOperations.Data.Migrations
{
    public partial class sopaddedfields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "sop",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Edited",
                table: "sop",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "sop");

            migrationBuilder.DropColumn(
                name: "Edited",
                table: "sop");
        }
    }
}
