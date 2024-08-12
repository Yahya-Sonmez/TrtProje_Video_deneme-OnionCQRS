using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YoutubeApi.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Priorty = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Details",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Detailid = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Details", x => x.id);
                    table.ForeignKey(
                        name: "FK_Details_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Details_Details_Detailid",
                        column: x => x.Detailid,
                        principalTable: "Details",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "CategoryProduct",
                columns: table => new
                {
                    Categoriesid = table.Column<int>(type: "int", nullable: false),
                    Productsid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProduct", x => new { x.Categoriesid, x.Productsid });
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Categories_Categoriesid",
                        column: x => x.Categoriesid,
                        principalTable: "Categories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Products_Productsid",
                        column: x => x.Productsid,
                        principalTable: "Products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "id", "CreatedDate", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 12, 15, 50, 56, 716, DateTimeKind.Local).AddTicks(9753), false, "Movies & Computers" },
                    { 2, new DateTime(2024, 8, 12, 15, 50, 56, 716, DateTimeKind.Local).AddTicks(9784), false, "Baby" },
                    { 3, new DateTime(2024, 8, 12, 15, 50, 56, 716, DateTimeKind.Local).AddTicks(9793), true, "Grocery" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "id", "CreatedDate", "IsDeleted", "Name", "ParentId", "Priorty" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 12, 15, 50, 56, 717, DateTimeKind.Local).AddTicks(2565), false, "Elektrik", 0, 1 },
                    { 2, new DateTime(2024, 8, 12, 15, 50, 56, 717, DateTimeKind.Local).AddTicks(2567), false, "Moda", 0, 2 },
                    { 3, new DateTime(2024, 8, 12, 15, 50, 56, 717, DateTimeKind.Local).AddTicks(2569), false, "Bilgisayar", 1, 1 },
                    { 4, new DateTime(2024, 8, 12, 15, 50, 56, 717, DateTimeKind.Local).AddTicks(2572), false, "Kadın", 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Details",
                columns: new[] { "id", "CategoryId", "CreatedDate", "Description", "Detailid", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 8, 12, 15, 50, 56, 721, DateTimeKind.Local).AddTicks(3118), "Makinesi quia.", null, false, "Sarmal." },
                    { 2, 3, new DateTime(2024, 8, 12, 15, 50, 56, 721, DateTimeKind.Local).AddTicks(3170), "Voluptas koştum ex esse makinesi.", null, true, "Eius anlamsız." },
                    { 3, 4, new DateTime(2024, 8, 12, 15, 50, 56, 721, DateTimeKind.Local).AddTicks(3277), "Consequuntur sevindi aut vitae göze.", null, false, "Ut." }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "BrandId", "CreatedDate", "Description", "Discount", "IsDeleted", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 8, 12, 15, 50, 56, 725, DateTimeKind.Local).AddTicks(5746), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 2.009637475954940m, false, 901.21m, "Small Rubber Keyboard" },
                    { 2, 3, new DateTime(2024, 8, 12, 15, 50, 56, 725, DateTimeKind.Local).AddTicks(5978), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 2.821639908126280m, false, 379.90m, "Incredible Plastic Chicken" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryProduct_Productsid",
                table: "CategoryProduct",
                column: "Productsid");

            migrationBuilder.CreateIndex(
                name: "IX_Details_CategoryId",
                table: "Details",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Details_Detailid",
                table: "Details",
                column: "Detailid");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryProduct");

            migrationBuilder.DropTable(
                name: "Details");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Brands");
        }
    }
}
