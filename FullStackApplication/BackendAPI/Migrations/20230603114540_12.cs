using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendAPI.Migrations
{
    public partial class _12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "FoodID", "FoodDescription", "FoodName", "FoodType", "VendorID" },
                values: new object[,]
                {
                    { 1, "Sunt voluptates velit dolorum.", "Aspestos Flavoured sausages", "Beverage", 2 },
                    { 2, "Autem molestiae quis voluptatem pariatur ut.", "Bacon Flavoured Icecream", "Cake", 1 },
                    { 3, "Quis eveniet perspiciatis dolorum quia.", "Mac and Cheese Filled Doughnuts", "Cake", 2 },
                    { 4, "Ullam aut officiis deleniti commodi.", "frostly Flakes Flavoured Milk", "Muffin", 1 },
                    { 5, "Reiciendis aut culpa tenetur et tempora sed quo maiores.", "Plastic Cheese Burger", "Muffin", 2 },
                    { 6, "Laborum eum ipsam.", "Apple pie arsenic surpise", "Cake", 2 },
                    { 7, "Animi architecto est.", "A Warm Apple pie", "Breads", 1 },
                    { 8, "Vel nisi modi sit maxime maxime sunt.", "Cardboard Pizza", "Beverage", 1 },
                    { 9, "Ab repudiandae voluptatem magni debitis sed iure laboriosam incidunt.", "Chocolate Cake", "Burger", 1 },
                    { 10, "Est alias sed magnam reiciendis voluptas.", "Live Plus Energy Drink", "Cupcake", 2 },
                    { 11, "Distinctio error voluptas fuga iusto harum necessitatibus quo.", "Oliver's Favorite Food", "Beverage", 2 }
                });

            migrationBuilder.InsertData(
                table: "Furniture",
                columns: new[] { "furnitureID", "VendorID", "furnitureDescription", "furnitureName", "furnitureType" },
                values: new object[,]
                {
                    { 1, 2, "Temporibus eaque assumenda expedita voluptates animi magnam vero consequuntur cum.", "Thrustmaster 1000", "Chair" },
                    { 2, 1, "Reiciendis sed est sed labore aut qui quisquam quia quia.", "The Pull Out", "Bed" },
                    { 3, 1, "Dolores vel a blanditiis ex eveniet corrupti autem et unde.", "The waterbed", "Chair" },
                    { 4, 2, "Enim placeat dolorem sapiente.", "regretabed", "Bed" }
                });

            migrationBuilder.InsertData(
                table: "Vehicle",
                columns: new[] { "vehicleID", "VendorID", "vehicleDescription", "vehicleName", "vehicleType" },
                values: new object[,]
                {
                    { 1, 1, "Autem sit beatae. Deleniti quis officia architecto. Possimus consectetur ipsum. Sapiente cumque qui quod qui atque et vero enim.", "Honda Del Sol", "StationWagon" },
                    { 2, 2, "Doloremque libero placeat nihil accusamus autem sit placeat. Autem nobis totam. Repudiandae voluptatum aut blanditiis dolor nihil alias. Natus sunt quaerat est aut cupiditate reprehenderit vitae provident.", "Honda Accord", "Shitbox" },
                    { 3, 2, "Quia voluptas ut corrupti ex maxime. Itaque non qui modi sed architecto eveniet ullam. Ab illo illum explicabo eveniet tempore.", "Holden Crewman  S", "Shitbox" },
                    { 4, 1, "Non nesciunt dolore minima placeat. Rerum eum enim at modi qui voluptatibus ut maxime quidem. Consequuntur enim esse sint accusamus. Non ipsam et libero.", "Holden Crewman SS", "Shitbox" },
                    { 5, 2, "Odio sit assumenda cupiditate sunt corrupti blanditiis saepe voluptatem. Adipisci ullam officia qui magnam similique debitis quia ipsam expedita. Rerum perferendis molestiae sunt occaecati. Et aliquam qui quas.", "Nissan Tiida Latio", "StationWagon" },
                    { 6, 1, "Ut et similique laudantium temporibus. Magni iure qui recusandae sit magni. Vero voluptatem quis et repudiandae et mollitia eaque.", "Mazda Verisa", "HatchBack" },
                    { 7, 1, "Doloribus delectus ad sunt. Qui deserunt illum magnam soluta facilis ab error est ipsum. Eius exercitationem aut rerum id vitae cupiditate.", "Ford Falcon FG XR6", "HatchBack" },
                    { 8, 1, "Dolore dolore numquam doloribus est blanditiis maiores consequatur quia. Repellat provident quia nihil reiciendis at quia non ut placeat. Corrupti in voluptates ipsum repellendus facilis. Voluptas voluptatem voluptatibus autem corporis ea dolorem vel.", "Ford Falcon BA XR8", "StationWagon" },
                    { 9, 1, "Omnis quaerat et amet. Voluptatem amet tenetur at. Tenetur reprehenderit et delectus nostrum et.", "Nissan Cefiro", "Sedan" },
                    { 10, 2, "Facilis quis qui odit. Ratione accusamus debitis dolorum sed reprehenderit dignissimos voluptas distinctio cumque. Maiores ipsam non voluptatem voluptatem laborum. Sed a vero quia est consectetur natus dolor molestiae ullam.", "Nissan Stagea", "StationWagon" },
                    { 11, 1, "Accusantium maxime vero. Exercitationem dolorum vel omnis qui et aut aliquam deleniti cupiditate. Quia recusandae eaque. Neque voluptatem consequatur quo veniam impedit porro praesentium.", "Subaru WRX", "HatchBack" }
                });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "VendorID", "Description", "Location", "Name" },
                values: new object[,]
                {
                    { 1, "Voluptates dolore consectetur autem.", "910 Langworth Circles", "ElixirPrime Group" },
                    { 2, "Sint autem sunt quia quia ea delectus saepe.", "234 Adelbert Glens", "Metabolic sustenance" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Furniture",
                keyColumn: "furnitureID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Furniture",
                keyColumn: "furnitureID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Furniture",
                keyColumn: "furnitureID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Furniture",
                keyColumn: "furnitureID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "VendorID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "VendorID",
                keyValue: 2);
        }
    }
}
