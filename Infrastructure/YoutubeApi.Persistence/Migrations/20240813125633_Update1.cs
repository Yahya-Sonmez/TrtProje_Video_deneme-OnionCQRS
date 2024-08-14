using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YoutubeApi.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Update1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryProduct");

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => new { x.ProductId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_ProductCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCategories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 8, 13, 15, 56, 29, 117, DateTimeKind.Local).AddTicks(8186), "Kids" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 8, 13, 15, 56, 29, 118, DateTimeKind.Local).AddTicks(128), "Industrial & Tools" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 8, 13, 15, 56, 29, 118, DateTimeKind.Local).AddTicks(150), "Outdoors" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 15, 56, 29, 118, DateTimeKind.Local).AddTicks(2727));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 15, 56, 29, 118, DateTimeKind.Local).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 15, 56, 29, 118, DateTimeKind.Local).AddTicks(2732));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 15, 56, 29, 118, DateTimeKind.Local).AddTicks(2734));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 8, 13, 15, 56, 29, 122, DateTimeKind.Local).AddTicks(176), "Patlıcan ışık.", "Karşıdakine." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 8, 13, 15, 56, 29, 122, DateTimeKind.Local).AddTicks(225), "Aliquam amet aspernatur quasi doğru.", "Quia de." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 8, 13, 15, 56, 29, 122, DateTimeKind.Local).AddTicks(351), "Quasi gördüm yazın iure değerli.", "Düşünüyor." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 8, 13, 15, 56, 29, 126, DateTimeKind.Local).AddTicks(5443), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 2.016985288990980m, 212.89m, "Small Soft Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 8, 13, 15, 56, 29, 126, DateTimeKind.Local).AddTicks(5657), "The Football Is Good For Training And Recreational Purposes", 2.61286596768340m, 448.58m, "Sleek Steel Sausages" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_CategoryId",
                table: "ProductCategories",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductCategories");

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

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 8, 12, 15, 50, 56, 716, DateTimeKind.Local).AddTicks(9753), "Movies & Computers" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 8, 12, 15, 50, 56, 716, DateTimeKind.Local).AddTicks(9784), "Baby" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 8, 12, 15, 50, 56, 716, DateTimeKind.Local).AddTicks(9793), "Grocery" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 15, 50, 56, 717, DateTimeKind.Local).AddTicks(2565));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 15, 50, 56, 717, DateTimeKind.Local).AddTicks(2567));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 15, 50, 56, 717, DateTimeKind.Local).AddTicks(2569));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 15, 50, 56, 717, DateTimeKind.Local).AddTicks(2572));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 8, 12, 15, 50, 56, 721, DateTimeKind.Local).AddTicks(3118), "Makinesi quia.", "Sarmal." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 8, 12, 15, 50, 56, 721, DateTimeKind.Local).AddTicks(3170), "Voluptas koştum ex esse makinesi.", "Eius anlamsız." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 8, 12, 15, 50, 56, 721, DateTimeKind.Local).AddTicks(3277), "Consequuntur sevindi aut vitae göze.", "Ut." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 8, 12, 15, 50, 56, 725, DateTimeKind.Local).AddTicks(5746), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 2.009637475954940m, 901.21m, "Small Rubber Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 8, 12, 15, 50, 56, 725, DateTimeKind.Local).AddTicks(5978), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 2.821639908126280m, 379.90m, "Incredible Plastic Chicken" });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryProduct_Productsid",
                table: "CategoryProduct",
                column: "Productsid");
        }
    }
}
