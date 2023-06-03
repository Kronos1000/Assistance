using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    public partial class intialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Food",
                columns: table => new
                {
                    FoodID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoodType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoodDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Food", x => x.FoodID);
                });

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
                name: "Vehicles",
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
                    table.PrimaryKey("PK_Vehicles", x => x.vehicleID);
                });

            migrationBuilder.CreateTable(
                name: "Vendor",
                columns: table => new
                {
                    VendorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehiclesvehicleID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendor", x => x.VendorID);
                    table.ForeignKey(
                        name: "FK_Vendor_Vehicles_VehiclesvehicleID",
                        column: x => x.VehiclesvehicleID,
                        principalTable: "Vehicles",
                        principalColumn: "vehicleID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vendor_VehiclesvehicleID",
                table: "Vendor",
                column: "VehiclesvehicleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Food");

            migrationBuilder.DropTable(
                name: "Furniture");

            migrationBuilder.DropTable(
                name: "Vendor");

            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
