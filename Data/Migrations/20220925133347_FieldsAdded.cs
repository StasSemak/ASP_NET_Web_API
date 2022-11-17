using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class FieldsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Battery",
                table: "Phones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Phones",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Battery", "ImagePath" },
                values: new object[] { 4500, "https://fdn2.gsmarena.com/vv/pics/samsung/samsung-galaxy-s20-fe-5g-1.jpg" });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Battery", "ImagePath" },
                values: new object[] { 3240, "https://fdn2.gsmarena.com/vv/pics/apple/apple-iphone-13-01.jpg" });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Battery", "ImagePath" },
                values: new object[] { 4614, "https://fdn2.gsmarena.com/vv/pics/google/google-pixel-6-1.jpg" });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Battery", "ImagePath" },
                values: new object[] { 5000, "https://fdn2.gsmarena.com/vv/pics/xiaomi/xiaomi-redmi-10-5g-1.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Battery",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Phones");
        }
    }
}
