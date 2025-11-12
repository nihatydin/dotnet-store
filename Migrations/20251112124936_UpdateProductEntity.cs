using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dotnet_store.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Products",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Products",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Image", "ProductName" },
                values: new object[] { "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptate iusto voluptatem similique cupiditate officiis expedita maxime nihil placeat ad, rem quis tenetur consequuntur quia praesentium odit ex vel id. Asperiores.", "1.jpeg", "Apple Iphone 10" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Active", "Description", "Image", "ProductName" },
                values: new object[] { true, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptate iusto voluptatem similique cupiditate officiis expedita maxime nihil placeat ad, rem quis tenetur consequuntur quia praesentium odit ex vel id. Asperiores.", "2.jpeg", "Apple Iphone 11" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Image", "ProductName" },
                values: new object[] { "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptate iusto voluptatem similique cupiditate officiis expedita maxime nihil placeat ad, rem quis tenetur consequuntur quia praesentium odit ex vel id. Asperiores.", "3.jpeg", "Apple Iphone 12" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Image", "ProductName" },
                values: new object[] { "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptate iusto voluptatem similique cupiditate officiis expedita maxime nihil placeat ad, rem quis tenetur consequuntur quia praesentium odit ex vel id. Asperiores.", "4.jpeg", "Apple Iphone 13" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Image", "ProductName" },
                values: new object[] { "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptate iusto voluptatem similique cupiditate officiis expedita maxime nihil placeat ad, rem quis tenetur consequuntur quia praesentium odit ex vel id. Asperiores.", "5.jpeg", "Apple Iphone 14" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Image", "ProductName" },
                values: new object[] { "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptate iusto voluptatem similique cupiditate officiis expedita maxime nihil placeat ad, rem quis tenetur consequuntur quia praesentium odit ex vel id. Asperiores.", "6.jpeg", "Apple Iphone 15" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Active", "Description", "Image", "Price", "ProductName" },
                values: new object[,]
                {
                    { 7, true, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptate iusto voluptatem similique cupiditate officiis expedita maxime nihil placeat ad, rem quis tenetur consequuntur quia praesentium odit ex vel id. Asperiores.", "7.jpeg", 92000.0, "Apple Iphone 16" },
                    { 8, true, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptate iusto voluptatem similique cupiditate officiis expedita maxime nihil placeat ad, rem quis tenetur consequuntur quia praesentium odit ex vel id. Asperiores.", "8.jpeg", 102000.0, "Apple Iphone 17" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProductName",
                value: "Apple Iphone 12");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Active", "ProductName" },
                values: new object[] { false, "Apple Iphone 13" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProductName",
                value: "Apple Iphone 14");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ProductName",
                value: "Apple Iphone 15");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ProductName",
                value: "Apple Iphone 16");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ProductName",
                value: "Apple Iphone 17");
        }
    }
}
