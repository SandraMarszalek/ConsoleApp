using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dictionary",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlWord = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngWord = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dictionary", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Car",
                columns: new[] { "Id", "Discount", "Model", "Price" },
                values: new object[,]
                {
                    { 10001, 12, "ModelX", 100000.0 },
                    { 20002, 8, "ModelY", 145000.0 },
                    { 30003, 14, "ModelZ", 243000.0 }
                });

            migrationBuilder.InsertData(
                table: "Dictionary",
                columns: new[] { "Id", "EngWord", "PlWord" },
                values: new object[,]
                {
                    { 10001, "one", "jeden" },
                    { 20002, "two", "dwa" },
                    { 30003, "three", "trzy" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Car");

            migrationBuilder.DropTable(
                name: "Dictionary");
        }
    }
}
