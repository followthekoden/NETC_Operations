using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NETCOperations.Data.Migrations
{
    public partial class scoandpowerlogs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PowerLogsViewModel",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    A = table.Column<int>(nullable: false),
                    B = table.Column<int>(nullable: false),
                    C = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Day = table.Column<string>(nullable: true),
                    Kw = table.Column<int>(nullable: false),
                    kva = table.Column<int>(nullable: false),
                    pf = table.Column<double>(nullable: false),
                    ups = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PowerLogsViewModel", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "scoViewModel",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    APocPrimary = table.Column<string>(nullable: true),
                    APocSecondary = table.Column<string>(nullable: true),
                    AfterHourCallback = table.Column<bool>(nullable: false),
                    HostName = table.Column<string>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    OSPocPrimary = table.Column<string>(nullable: true),
                    OSPocSecondary = table.Column<string>(nullable: true),
                    dbaadmin = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_scoViewModel", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PowerLogsViewModel");

            migrationBuilder.DropTable(
                name: "scoViewModel");
        }
    }
}
