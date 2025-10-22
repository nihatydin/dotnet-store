using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dotnet_store.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductName = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Active = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Active", "Price", "ProductName" },
                values: new object[,]
                {
                    { 1, true, 32000.0, "Apple Iphone 12" },
                    { 2, false, 42000.0, "Apple Iphone 13" },
                    { 3, true, 52000.0, "Apple Iphone 14" },
                    { 4, true, 62000.0, "Apple Iphone 15" },
                    { 5, true, 72000.0, "Apple Iphone 16" },
                    { 6, false, 82000.0, "Apple Iphone 17" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
