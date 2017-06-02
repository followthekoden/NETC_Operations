using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NETCOperations.Data.Migrations
{
    public partial class hurricanefix2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HurricaneServerModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Bldg = table.Column<string>(nullable: true),
                    Enviroment = table.Column<string>(nullable: true),
                    Hurricane = table.Column<bool>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    Primary = table.Column<string>(nullable: true),
                    Purpose = table.Column<string>(nullable: true),
                    Rack = table.Column<string>(nullable: true),
                    Room = table.Column<string>(nullable: true),
                    Secondary = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HurricaneServerModel", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HurricaneServerModel");
        }
    }
}
