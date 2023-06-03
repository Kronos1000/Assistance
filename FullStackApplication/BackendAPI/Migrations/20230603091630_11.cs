using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendAPI.Migrations
{
    public partial class _11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Furniture",
                columns: table => new
                {
                    furnitureID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    furnitureName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    furnitureType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    furnitureDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VendorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Furniture", x => x.furnitureID);
                });

            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    vehicleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    vehicleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    vehicleType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    vehicleDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.vehicleID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Furniture");

            migrationBuilder.DropTable(
                name: "Vehicle");
        }
    }
}
