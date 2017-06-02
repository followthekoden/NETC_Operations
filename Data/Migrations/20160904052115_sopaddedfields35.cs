using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NETCOperations.Data.Migrations
{
    public partial class sopaddedfields35 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "sop",
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "sop",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "sop",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "sop",
                nullable: true);
        }
    }
}
