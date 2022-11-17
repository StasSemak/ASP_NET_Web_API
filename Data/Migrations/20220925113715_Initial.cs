using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Phones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Screen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RAM = table.Column<int>(type: "int", nullable: false),
                    Storage = table.Column<int>(type: "int", nullable: false),
                    Camera = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phones", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Phones",
                columns: new[] { "Id", "Camera", "Model", "Price", "RAM", "Screen", "Storage" },
                values: new object[,]
                {
                    { 1, "12MP triple main, 32 MP front", "SAMSUNG Galaxy S20", 769.99m, 8, "6.5 inches", 256 },
                    { 2, "12MP dual main, 12 MP front", "Apple iPhone 13", 829.99m, 4, "6.1 inches", 256 },
                    { 3, "50MP dual main, 8 MP front", "Google Pixel 6", 599m, 8, "6.4 inches", 256 },
                    { 4, "50MP dual main, 8 MP front", "Xiaomi Redmi 11", 799.99m, 6, "6.58 inches", 128 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Phones");
        }
    }
}
