using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendAPI.Migrations
{
    public partial class _17 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 1,
                columns: new[] { "FoodDescription", "FoodName", "FoodType", "VendorID" },
                values: new object[] { "Culpa possimus sed molestiae.", "Aspestos Flavoured sausages", "Muffin", 2 });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 2,
                columns: new[] { "FoodDescription", "FoodName", "FoodType" },
                values: new object[] { "Velit non quisquam quia.", "Bacon Flavoured Icecream", "Snack" });

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "FoodID", "FoodDescription", "FoodName", "FoodType", "VendorID" },
                values: new object[,]
                {
                    { 3, "Ullam consequatur deleniti qui placeat ut ad.", "Mac and Cheese Filled Doughnuts", "Cupcake", 2 },
                    { 4, "Voluptates dolore et amet sunt aliquid et sequi.", "frostly Flakes Flavoured Milk", "Cake", 2 },
                    { 5, "Qui assumenda delectus recusandae est velit ipsam dignissimos temporibus.", "Plastic Cheese Burger", "Burger", 2 },
                    { 6, "Ipsum optio earum autem dicta cupiditate voluptatem qui suscipit.", "Apple pie arsenic surpise", "Cupcake", 1 },
                    { 7, "Quam voluptatem ullam sit.", "A Warm Apple pie", "Snack", 1 },
                    { 8, "Ut id ullam omnis recusandae tempore.", "Cardboard Pizza", "Burger", 1 },
                    { 9, "Sint voluptatem in ut quidem voluptas.", "Chocolate Cake", "Cupcake", 2 },
                    { 10, "Velit neque quia et temporibus rerum.", "Live Plus Energy Drink", "Snack", 2 },
                    { 11, "Provident iure qui quam voluptatem accusamus sint tempore fuga cum.", "Oliver's Favorite Food", "Muffin", 2 }
                });

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "furnitureID",
                keyValue: 1,
                columns: new[] { "furnitureDescription", "furnitureType" },
                values: new object[] { "Nihil aspernatur cum.", "Occasional Furniture" });

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "furnitureID",
                keyValue: 2,
                columns: new[] { "furnitureDescription", "furnitureName", "furnitureType" },
                values: new object[] { "Quia sequi harum.", "The Pull Out", "Occasional Furniture" });

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "furnitureID",
                keyValue: 3,
                columns: new[] { "furnitureDescription", "furnitureName", "furnitureType" },
                values: new object[] { "Nesciunt nemo molestiae sapiente ut et labore.", "The waterbed", "Chair" });

            migrationBuilder.InsertData(
                table: "Furniture",
                columns: new[] { "furnitureID", "VendorID", "furnitureDescription", "furnitureName", "furnitureType" },
                values: new object[] { 4, 1, "Illum dolor praesentium doloribus suscipit saepe.", "regretabed", "Occasional Furniture" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 1,
                columns: new[] { "vehicleDescription", "vehicleType" },
                values: new object[] { "Voluptates quos consequatur delectus quos maxime aliquam totam. Repudiandae esse unde pariatur ut. Qui voluptates reiciendis et. Sunt harum ullam iure et quo. Praesentium id veritatis minima eius ut maiores.", "Ute" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 2,
                columns: new[] { "vehicleDescription", "vehicleType" },
                values: new object[] { "Neque voluptas enim libero magnam dolores. Voluptates repudiandae dicta ipsam blanditiis. Dolor rerum doloremque voluptates quia tenetur quae. Sequi eaque et voluptatem rem facilis dolores quam similique. Omnis sed mollitia numquam rerum totam qui similique ipsam voluptatem. Animi iste molestiae molestias.", "Ute" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 3,
                columns: new[] { "VendorID", "vehicleDescription" },
                values: new object[] { 2, "Sit quo vel alias sit neque. Perferendis sit totam nam nesciunt sequi id laboriosam rerum. Et earum inventore non magnam corrupti dolores voluptate." });

            migrationBuilder.InsertData(
                table: "Vehicle",
                columns: new[] { "vehicleID", "VendorID", "vehicleDescription", "vehicleName", "vehicleType" },
                values: new object[,]
                {
                    { 4, 2, "Minus quia recusandae dolore magni amet nam eligendi necessitatibus dolor. Mollitia ad temporibus id nesciunt doloribus praesentium. Perspiciatis ea necessitatibus corporis itaque. Magnam molestiae impedit labore assumenda excepturi rerum. Repellat adipisci dolor. Fugiat similique et quam hic iure est ab rerum aperiam.", "Holden Crewman SS", "StationWagon" },
                    { 5, 2, "Autem rerum enim architecto voluptas quas. Non similique magni architecto earum rerum at rerum iste. Dolorum enim aut nulla dignissimos assumenda ut alias aut. Esse et molestias laborum repellat nulla. Ullam quaerat sunt neque ut qui. Voluptas recusandae aut.", "Nissan Tiida Latio", "HatchBack" },
                    { 6, 1, "Eum porro quia eius debitis enim et accusantium eum. Neque veniam dolorem temporibus labore vitae ut. Nobis et ad soluta mollitia assumenda deleniti alias sit.", "Mazda Verisa", "HatchBack" },
                    { 7, 1, "Ipsa ipsa exercitationem nulla inventore. Et praesentium autem quis rem eveniet. Dignissimos nisi sed. Sint omnis hic. Officia eius aliquid veniam eos. Sunt eius et mollitia odio in dolor sed.", "Ford Falcon FG XR6", "Sedan" },
                    { 8, 1, "Suscipit expedita incidunt nam. Laudantium vitae quidem expedita qui illo magnam. Asperiores eum culpa illum quae ex quos. Molestias provident cum officiis non. Ut nihil quis. Alias quam et repudiandae et doloremque qui placeat deleniti.", "Ford Falcon BA XR8", "HatchBack" },
                    { 9, 1, "Ipsam itaque animi non sunt adipisci veniam voluptatibus ea. Deleniti ad nam quasi nisi molestiae natus dolor non saepe. Vel ut natus a suscipit sed et provident autem et. Itaque a assumenda vero et iusto blanditiis maiores animi eos. Ullam doloribus id cum vel.", "Nissan Cefiro", "Sedan" },
                    { 10, 2, "Ea aspernatur nesciunt voluptatem. Accusantium magnam tempora asperiores molestias aut dolore. Cupiditate dolores voluptate officiis totam provident tempore rem repellendus et.", "Nissan Stagea", "HatchBack" },
                    { 11, 2, "Nemo repudiandae quisquam veniam earum magni sunt aut dolorem voluptatem. Harum consequatur quia accusantium. Perspiciatis repellat esse quia consequatur debitis sit quis. Cupiditate id ut ex. Accusantium enim accusantium aliquid sed voluptatem et autem sunt praesentium. Temporibus consequatur et provident ea esse.", "Subaru WRX", "Ute" }
                });

            migrationBuilder.UpdateData(
                table: "Vendor",
                keyColumn: "VendorID",
                keyValue: 1,
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Non voluptatem et saepe est ipsam molestiae consequatur qui enim.", "0744 Heathcote Stream", "Unlimited Problems Ltd." });

            migrationBuilder.UpdateData(
                table: "Vendor",
                keyColumn: "VendorID",
                keyValue: 2,
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Nobis qui optio iure velit et saepe ut qui ipsam.", "0477 Weimann Parkway", "Underwhelming Results Agency" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "furnitureDescription", "furnitureType" },
                values: new object[] { "Provident porro blanditiis porro praesentium voluptas aut.", "Bed" });

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "furnitureID",
                keyValue: 2,
                columns: new[] { "furnitureDescription", "furnitureName", "furnitureType" },
                values: new object[] { "Dolore libero ut impedit quia et.", "The waterbed", "Couch" });

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "furnitureID",
                keyValue: 3,
                columns: new[] { "furnitureDescription", "furnitureName", "furnitureType" },
                values: new object[] { "Ut est laborum.", "regretabed", "Occasional Furniture" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 1,
                columns: new[] { "vehicleDescription", "vehicleType" },
                values: new object[] { "Aliquid nihil sint exercitationem quia eveniet. Qui ut impedit facilis velit nam. Animi molestiae ratione. Voluptates rerum delectus cumque. Vel corrupti ad.", "HatchBack" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 2,
                columns: new[] { "vehicleDescription", "vehicleType" },
                values: new object[] { "Laborum quibusdam voluptatibus vero qui. Ut molestiae et molestiae eos. Alias quibusdam dolores sunt mollitia ullam animi. Praesentium omnis nam iste minus. Explicabo velit nulla unde ea est sint voluptatem. Fugiat corporis nostrum laudantium.", "Shitbox" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 3,
                columns: new[] { "VendorID", "vehicleDescription" },
                values: new object[] { 1, "Quia ea inventore ut dolores id. Est reiciendis quibusdam consequatur aut ullam ut exercitationem ratione fuga. Deserunt et provident qui ullam dolores fugiat." });

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
    }
}
