using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendAPI.Migrations
{
    public partial class _16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                keyValue: 4);

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

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 1,
                columns: new[] { "FoodDescription", "FoodName", "FoodType", "VendorID" },
                values: new object[] { "Eum in amet quia.", "Bacon Flavoured Icecream", "Breads", 1 });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 2,
                columns: new[] { "FoodDescription", "FoodName", "FoodType" },
                values: new object[] { "Vero numquam sit vitae et ab non ducimus quod corrupti.", "Oliver's Favorite Food", "Cupcake" });

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "furnitureID",
                keyValue: 1,
                columns: new[] { "VendorID", "furnitureDescription", "furnitureType" },
                values: new object[] { 2, "Provident porro blanditiis porro praesentium voluptas aut.", "Bed" });

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "furnitureID",
                keyValue: 2,
                columns: new[] { "furnitureDescription", "furnitureName" },
                values: new object[] { "Dolore libero ut impedit quia et.", "The waterbed" });

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "furnitureID",
                keyValue: 3,
                columns: new[] { "furnitureDescription", "furnitureName" },
                values: new object[] { "Ut est laborum.", "regretabed" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 1,
                columns: new[] { "VendorID", "vehicleDescription", "vehicleType" },
                values: new object[] { 1, "Aliquid nihil sint exercitationem quia eveniet. Qui ut impedit facilis velit nam. Animi molestiae ratione. Voluptates rerum delectus cumque. Vel corrupti ad.", "HatchBack" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 2,
                columns: new[] { "VendorID", "vehicleDescription", "vehicleType" },
                values: new object[] { 2, "Laborum quibusdam voluptatibus vero qui. Ut molestiae et molestiae eos. Alias quibusdam dolores sunt mollitia ullam animi. Praesentium omnis nam iste minus. Explicabo velit nulla unde ea est sint voluptatem. Fugiat corporis nostrum laudantium.", "Shitbox" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 3,
                columns: new[] { "VendorID", "vehicleDescription", "vehicleType" },
                values: new object[] { 1, "Quia ea inventore ut dolores id. Est reiciendis quibusdam consequatur aut ullam ut exercitationem ratione fuga. Deserunt et provident qui ullam dolores fugiat.", "Shitbox" });

            migrationBuilder.UpdateData(
                table: "Vendor",
                keyColumn: "VendorID",
                keyValue: 1,
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Mollitia quasi quia facere quos vel qui neque harum.", "6405 Welch Extensions", "Guaranteed Disappointment Corp." });

            migrationBuilder.UpdateData(
                table: "Vendor",
                keyColumn: "VendorID",
                keyValue: 2,
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Sit dolores et delectus accusamus.", "479 Tromp Center", "Procrastination Solutions" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 1,
                columns: new[] { "FoodDescription", "FoodName", "FoodType", "VendorID" },
                values: new object[] { "Modi praesentium reiciendis veritatis est iusto ratione dolore.", "Aspestos Flavoured sausages", "Cake", 2 });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 2,
                columns: new[] { "FoodDescription", "FoodName", "FoodType" },
                values: new object[] { "Exercitationem quia doloribus et ea et quidem voluptatum.", "Bacon Flavoured Icecream", "Burger" });

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "FoodID", "FoodDescription", "FoodName", "FoodType", "VendorID" },
                values: new object[,]
                {
                    { 3, "Rem et dolore omnis consequatur accusamus.", "Mac and Cheese Filled Doughnuts", "Cupcake", 1 },
                    { 4, "Quos blanditiis officiis voluptatem odio non iusto dolor.", "frostly Flakes Flavoured Milk", "Cupcake", 1 },
                    { 5, "Magni necessitatibus qui atque temporibus placeat in.", "Plastic Cheese Burger", "Snack", 1 },
                    { 6, "Maiores culpa consequatur totam cupiditate recusandae.", "Apple pie arsenic surpise", "Cake", 2 },
                    { 7, "Aut rem deserunt fugit quisquam non.", "A Warm Apple pie", "Cupcake", 2 },
                    { 8, "Ab architecto iste vero rerum voluptatem.", "Cardboard Pizza", "Snack", 1 },
                    { 9, "Non qui aut quia enim eligendi et fugiat quasi et.", "Chocolate Cake", "Beverage", 1 },
                    { 10, "Et ea aliquid omnis placeat.", "Live Plus Energy Drink", "Burger", 2 },
                    { 11, "Aut voluptas ad laboriosam iure in.", "Oliver's Favorite Food", "Beverage", 2 }
                });

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "furnitureID",
                keyValue: 1,
                columns: new[] { "VendorID", "furnitureDescription", "furnitureType" },
                values: new object[] { 1, "In dignissimos id.", "Occasional Furniture" });

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "furnitureID",
                keyValue: 2,
                columns: new[] { "furnitureDescription", "furnitureName" },
                values: new object[] { "Et repudiandae voluptatem sit odio aut laboriosam.", "The Pull Out" });

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "furnitureID",
                keyValue: 3,
                columns: new[] { "furnitureDescription", "furnitureName" },
                values: new object[] { "Sed iure omnis quibusdam.", "The waterbed" });

            migrationBuilder.InsertData(
                table: "Furniture",
                columns: new[] { "furnitureID", "VendorID", "furnitureDescription", "furnitureName", "furnitureType" },
                values: new object[] { 4, 1, "Et placeat minima et dolor et.", "regretabed", "Couch" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 1,
                columns: new[] { "VendorID", "vehicleDescription", "vehicleType" },
                values: new object[] { 2, "Eaque facilis omnis sed dolorum. Eveniet reiciendis explicabo earum omnis minus. Fuga reprehenderit tempora sapiente itaque sequi nihil accusamus. Fuga sunt rem aut est eos molestiae et. Aliquid dicta praesentium placeat. Maxime ratione harum deleniti.", "Sedan" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 2,
                columns: new[] { "VendorID", "vehicleDescription", "vehicleType" },
                values: new object[] { 1, "Sed dolores consequuntur quia fugiat distinctio. Ut quia voluptatem. Similique aut in libero facere. Dicta at est. Non autem debitis aliquid est nam cupiditate laboriosam magnam.", "Ute" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 3,
                columns: new[] { "VendorID", "vehicleDescription", "vehicleType" },
                values: new object[] { 2, "Expedita voluptates natus ad vel sed sed earum nemo voluptatem. Corrupti ex nobis optio perspiciatis et dolorem. Rerum quasi ipsa occaecati incidunt distinctio laboriosam. Ipsam repellendus repellendus suscipit nesciunt sint ut in consequatur. Est nihil quia. Ut vel nobis iste eum fugiat.", "Sedan" });

            migrationBuilder.InsertData(
                table: "Vehicle",
                columns: new[] { "vehicleID", "VendorID", "vehicleDescription", "vehicleName", "vehicleType" },
                values: new object[,]
                {
                    { 4, 1, "Eos ipsum voluptatem ullam nihil aut aliquid voluptatem. Qui numquam quia repellendus. Est et eum et consequatur in dolore.", "Holden Crewman SS", "StationWagon" },
                    { 5, 1, "Ratione non ipsum. Molestiae ut voluptates vel voluptatem quibusdam. Tempore illo architecto et voluptas ut voluptatem aut delectus similique. Officiis esse sunt aut minus molestiae sed quasi. Voluptatem voluptates possimus harum in.", "Nissan Tiida Latio", "Sedan" },
                    { 6, 1, "Dolor minus laboriosam consectetur voluptas ut qui molestiae. Sit accusamus corrupti repudiandae consequatur fuga at sit ut eum. Ipsum animi animi tempora. Mollitia est sit dolores ducimus nisi quia.", "Mazda Verisa", "Ute" },
                    { 7, 1, "Nobis hic odit ut dolores in sapiente. Esse aut delectus est ex. Et autem et qui officiis quibusdam ullam. Aspernatur quia dolores porro quasi optio.", "Ford Falcon FG XR6", "Ute" },
                    { 8, 2, "Eum sed dicta similique aut. Dicta quis est ipsum quidem ducimus consequatur. Qui voluptatem tempora consequatur ad aut provident. Porro quam error. Iure quo est nulla. Officia dolores aut et dolorem qui officia quasi maxime et.", "Ford Falcon BA XR8", "Shitbox" },
                    { 9, 1, "Suscipit facilis repellat in in. Unde aut sed aut cumque. Aut quibusdam ullam quis. Velit dolores qui. Est similique aliquid officia.", "Nissan Cefiro", "Shitbox" },
                    { 10, 1, "Pariatur ut culpa laborum odit qui. Recusandae rerum veniam possimus. Enim accusantium porro et nihil officia. Modi accusamus quibusdam suscipit nisi earum quas ullam fuga.", "Nissan Stagea", "HatchBack" },
                    { 11, 1, "Aspernatur nisi est. Ipsam vero culpa. Repellat esse minima. Qui quia maiores natus.", "Subaru WRX", "StationWagon" }
                });

            migrationBuilder.UpdateData(
                table: "Vendor",
                keyColumn: "VendorID",
                keyValue: 1,
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Libero quis et laborum vel reprehenderit vero.", "67063 Delbert Grove", "Kronos Incoporated" });

            migrationBuilder.UpdateData(
                table: "Vendor",
                keyColumn: "VendorID",
                keyValue: 2,
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Esse voluptatem dolores sed aut voluptates et.", "823 Thiel Ranch", "Kronos Incoporated" });
        }
    }
}
