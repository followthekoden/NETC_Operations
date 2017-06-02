using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NETCOperations.Data.Migrations
{
    public partial class hurricanefix3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Application",
                table: "HurricaneServerModel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HostName",
                table: "HurricaneServerModel",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Room",
                table: "HurricaneServerModel",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "Bldg",
                table: "HurricaneServerModel",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Application",
                table: "HurricaneServerModel");

            migrationBuilder.DropColumn(
                name: "HostName",
                table: "HurricaneServerModel");

            migrationBuilder.AlterColumn<string>(
                name: "Room",
                table: "HurricaneServerModel",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Bldg",
                table: "HurricaneServerModel",
                nullable: true);
        }
    }
}
