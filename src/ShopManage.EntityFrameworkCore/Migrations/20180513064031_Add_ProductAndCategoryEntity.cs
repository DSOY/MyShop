using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ShopManage.Migrations
{
    public partial class Add_ProductAndCategoryEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AbpCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ParentId = table.Column<int>(nullable: false),
                    Path = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbpProduct",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Barcode = table.Column<string>(maxLength: 64, nullable: true),
                    CategoryId = table.Column<int>(nullable: false),
                    Code = table.Column<string>(maxLength: 64, nullable: true),
                    CommentTimes = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    Creator = table.Column<int>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    FullDescription = table.Column<string>(maxLength: 512, nullable: true),
                    IsBest = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsNew = table.Column<int>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    Name = table.Column<string>(maxLength: 120, nullable: false),
                    OldPrice = table.Column<decimal>(nullable: false),
                    Picture = table.Column<string>(maxLength: 200, nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ShortDescription = table.Column<string>(maxLength: 256, nullable: true),
                    ShortName = table.Column<string>(maxLength: 80, nullable: true),
                    Size = table.Column<string>(maxLength: 20, nullable: false),
                    SoldNum = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    TenantID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpProduct", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbpProduct_AbpCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "AbpCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AbpProduct_CategoryId",
                table: "AbpProduct",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AbpProduct");

            migrationBuilder.DropTable(
                name: "AbpCategory");
        }
    }
}
