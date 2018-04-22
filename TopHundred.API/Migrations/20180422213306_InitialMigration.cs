using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TopHundred.API.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<byte[]>(nullable: true),
                    PasswordSalt = table.Column<byte[]>(nullable: true),
                    Username = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IcoItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: false),
                    EndTime = table.Column<DateTime>(nullable: false),
                    IcoTypeEnumeration = table.Column<int>(nullable: false),
                    IconLink = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    PriceCurrency = table.Column<string>(nullable: false),
                    Rank = table.Column<int>(nullable: false),
                    StartTime = table.Column<DateTime>(nullable: false),
                    Status = table.Column<string>(maxLength: 20, nullable: false),
                    Symbol = table.Column<string>(maxLength: 10, nullable: false),
                    TotalTokenCount = table.Column<int>(nullable: false),
                    UserId = table.Column<Guid>(nullable: true),
                    WhitePaper = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IcoItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IcoItems_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IcoLink",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IcoItemId = table.Column<Guid>(nullable: false),
                    Link = table.Column<string>(nullable: true),
                    LinkIcon = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IcoLink", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IcoLink_IcoItems_IcoItemId",
                        column: x => x.IcoItemId,
                        principalTable: "IcoItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IcoItems_UserId",
                table: "IcoItems",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_IcoLink_IcoItemId",
                table: "IcoLink",
                column: "IcoItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IcoLink");

            migrationBuilder.DropTable(
                name: "IcoItems");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
