using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TopHundred.API.Migrations
{
    public partial class AddedNewsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AuthorFirstName = table.Column<string>(nullable: true),
                    AuthorImage = table.Column<string>(nullable: true),
                    AuthorLastName = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    ContentImage = table.Column<string>(nullable: true),
                    HighLight = table.Column<string>(nullable: true),
                    HighLightImage = table.Column<string>(nullable: true),
                    PublishDate = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "News");
        }
    }
}
