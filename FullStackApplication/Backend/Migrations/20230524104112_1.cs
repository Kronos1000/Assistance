using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    public partial class _1 : Migration
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

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "FoodID", "FoodDescription", "FoodName", "FoodType", "VendorID" },
                values: new object[,]
                {
                    { 1, "Similique optio odit illum sint.", "frostly Flakes Flavoured Milk", "Breads", 2 },
                    { 2, "Sit quidem unde.", "Big Mac", "Breads", 2 },
                    { 3, "Temporibus eveniet sit explicabo.", "Chocolate Cake", "Breads", 1 },
                    { 4, "Quod vel ipsam quia.", "frostly Flakes Flavoured Milk", "Burger", 1 },
                    { 5, "Unde odit quia.", "Bacon Flavoured Icecream", "Snack", 2 },
                    { 6, "Sequi sed expedita adipisci sed placeat et nesciunt nulla.", "Mac and Cheese Filled Doughnuts", "Beverage", 2 },
                    { 7, "Mollitia cum ad et itaque.", "Cardboard Pizza", "Burger", 2 },
                    { 8, "Nihil velit voluptas laudantium sunt velit.", "A Warm Apple pie", "Muffin", 2 },
                    { 9, "Esse quos enim natus.", "Cardboard Pizza", "Snack", 2 }
                });

            migrationBuilder.InsertData(
                table: "Furniture",
                columns: new[] { "furnitureID", "VendorID", "furnitureDescription", "furnitureName", "furnitureType" },
                values: new object[,]
                {
                    { 2511, 1, "Voluptatibus unde molestiae non ea possimus fugiat ut.", "Leather couch 3000", "Occasional Furniture" },
                    { 2804, 2, "Ut aut quis iure a impedit fugiat dolorum.", "Leather couch 3000", "Bed" },
                    { 3198, 1, "Tempore quo quod adipisci unde.", "The Pull Out", "Couch" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "vehicleID", "VendorID", "vehicleDescription", "vehicleName", "vehicleType" },
                values: new object[,]
                {
                    { 59003, 2, "Alias eius quam est cupiditate eos expedita ipsum cum error. Sit impedit saepe similique ut et. Incidunt ipsam perspiciatis rerum aliquid sequi eveniet doloremque. Minus nihil nisi consequatur. Omnis nihil sapiente vel cupiditate facilis dignissimos numquam deserunt dolorem.", "Nissan Cefiro", "Shitbox" },
                    { 64406, 1, "Tempore accusantium fugit. Est soluta rerum sapiente sint laudantium voluptatem ut. Consequatur minima quod sequi commodi quos magnam at voluptatum earum. Consequatur beatae dignissimos quas.", "Honda Civic", "StationWagon" },
                    { 77085, 2, "Perferendis magnam fugiat quia aliquid maxime odit asperiores accusantium nostrum. Facere sapiente quaerat sunt unde corrupti veritatis. Sapiente debitis qui. Quibusdam et harum omnis eaque. Aperiam exercitationem est. Qui omnis suscipit unde.", "Honda Civic", "Shitbox" },
                    { 78582, 2, "Consequatur quo facere quidem provident. Nulla consequuntur voluptatum. Tenetur ut et excepturi dignissimos corporis officiis. Repellat autem eligendi nihil sint vero eum ad.", "Holden Crewman  S", "Shitbox" }
                });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "VendorID", "Description", "Location", "Name", "VehiclesvehicleID" },
                values: new object[,]
                {
                    { 1, "Animi velit at voluptatum expedita nisi itaque et ducimus nulla.", "92145 Devonte Rapids", "Procrastination Solutions", null },
                    { 2, "Neque quia sit.", "932 Clark Summit", "Efficiency Experts Inc. (Don't Hold Your Breath)", null }
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
