using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DocConverter.Infrastructure.Migrations
{
    public partial class InitTemplateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "t_TemplateElements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateBy = table.Column<string>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    TypeId = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_TemplateElements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "t_TypeCollections",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_TypeCollections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "t_Templates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateBy = table.Column<string>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    VersionNumber = table.Column<int>(nullable: false),
                    BaseElementId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_Templates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_t_Templates_t_TemplateElements_BaseElementId",
                        column: x => x.BaseElementId,
                        principalTable: "t_TemplateElements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "t_TypeValues",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: true),
                    CollectionId = table.Column<int>(nullable: false),
                    Desc = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_TypeValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_t_TypeValues_t_TypeCollections_CollectionId",
                        column: x => x.CollectionId,
                        principalTable: "t_TypeCollections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_t_Templates_BaseElementId",
                table: "t_Templates",
                column: "BaseElementId");

            migrationBuilder.CreateIndex(
                name: "IX_t_TypeValues_CollectionId",
                table: "t_TypeValues",
                column: "CollectionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "t_Templates");

            migrationBuilder.DropTable(
                name: "t_TypeValues");

            migrationBuilder.DropTable(
                name: "t_TemplateElements");

            migrationBuilder.DropTable(
                name: "t_TypeCollections");
        }
    }
}
