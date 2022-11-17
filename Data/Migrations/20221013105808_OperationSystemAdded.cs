using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class OperationSystemAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OperationSystemId",
                table: "Phones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "OperationSystems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationSystems", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "OperationSystems",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Android 10" },
                    { 2, "Android 11" },
                    { 3, "Android 12" },
                    { 4, "Android 13" },
                    { 5, "iOS 13" },
                    { 6, "iOS 14" },
                    { 7, "iOS 15" },
                    { 8, "iOS 16" }
                });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 1,
                column: "OperationSystemId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 2,
                column: "OperationSystemId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 3,
                column: "OperationSystemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 4,
                column: "OperationSystemId",
                value: 4);

            migrationBuilder.CreateIndex(
                name: "IX_Phones_OperationSystemId",
                table: "Phones",
                column: "OperationSystemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Phones_OperationSystems_OperationSystemId",
                table: "Phones",
                column: "OperationSystemId",
                principalTable: "OperationSystems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Phones_OperationSystems_OperationSystemId",
                table: "Phones");

            migrationBuilder.DropTable(
                name: "OperationSystems");

            migrationBuilder.DropIndex(
                name: "IX_Phones_OperationSystemId",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "OperationSystemId",
                table: "Phones");
        }
    }
}
