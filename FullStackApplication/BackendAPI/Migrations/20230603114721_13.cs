using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendAPI.Migrations
{
    public partial class _13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vendor",
                keyColumn: "VendorID",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 1,
                columns: new[] { "FoodDescription", "FoodType", "VendorID" },
                values: new object[] { "Hic aut aut quis numquam dolor ut est cupiditate.", "Cupcake", 1 });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 2,
                columns: new[] { "FoodDescription", "FoodType" },
                values: new object[] { "Sapiente voluptatem omnis omnis commodi.", "Snack" });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 3,
                columns: new[] { "FoodDescription", "FoodType", "VendorID" },
                values: new object[] { "Sint ea quia et culpa.", "Muffin", 1 });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 4,
                columns: new[] { "FoodDescription", "FoodType", "VendorID" },
                values: new object[] { "Sit dolor repudiandae quos neque et sunt quos.", "Snack", 2 });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 5,
                columns: new[] { "FoodDescription", "FoodType", "VendorID" },
                values: new object[] { "Consectetur minus doloribus rerum minima totam modi et sunt.", "Burger", 1 });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 6,
                columns: new[] { "FoodDescription", "FoodType", "VendorID" },
                values: new object[] { "Voluptates animi quia illo quas quo ut.", "Cupcake", 1 });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 7,
                columns: new[] { "FoodDescription", "FoodType", "VendorID" },
                values: new object[] { "Incidunt libero vel.", "Cupcake", 2 });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 8,
                column: "FoodDescription",
                value: "Natus aut qui et.");

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 9,
                columns: new[] { "FoodDescription", "FoodType", "VendorID" },
                values: new object[] { "Est est eius commodi accusamus velit quibusdam.", "Breads", 2 });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 10,
                columns: new[] { "FoodDescription", "FoodType", "VendorID" },
                values: new object[] { "Quisquam pariatur quia.", "Beverage", 1 });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 11,
                columns: new[] { "FoodDescription", "FoodType", "VendorID" },
                values: new object[] { "Ea minus saepe quas nobis aut earum.", "Breads", 1 });

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "furnitureID",
                keyValue: 1,
                columns: new[] { "furnitureDescription", "furnitureType" },
                values: new object[] { "Est occaecati iusto blanditiis.", "Bed" });

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "furnitureID",
                keyValue: 2,
                columns: new[] { "VendorID", "furnitureDescription", "furnitureType" },
                values: new object[] { 2, "Rem magnam deleniti eum officiis sed.", "Couch" });

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "furnitureID",
                keyValue: 3,
                columns: new[] { "VendorID", "furnitureDescription", "furnitureType" },
                values: new object[] { 2, "Non consequatur eaque molestias asperiores animi in explicabo.", "Couch" });

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "furnitureID",
                keyValue: 4,
                columns: new[] { "VendorID", "furnitureDescription", "furnitureType" },
                values: new object[] { 1, "Nihil possimus quas aut quae velit ut veniam sint.", "Couch" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 1,
                columns: new[] { "VendorID", "vehicleDescription", "vehicleType" },
                values: new object[] { 2, "Illum facilis voluptatibus minus et. Architecto quaerat iure necessitatibus illo. Est ut est. Quidem qui est porro sed tenetur sed voluptas fugit sed.", "Ute" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 2,
                columns: new[] { "VendorID", "vehicleDescription" },
                values: new object[] { 1, "Modi numquam et nobis ipsum voluptas. Nobis aspernatur facilis assumenda qui reiciendis. Omnis suscipit perspiciatis et iste. Animi impedit impedit repudiandae labore fugiat." });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 3,
                columns: new[] { "VendorID", "vehicleDescription", "vehicleType" },
                values: new object[] { 1, "Velit voluptatem ea accusamus non et quasi animi qui. Ratione est rerum. Expedita omnis et et. Error doloremque quod ut velit facere ad.", "StationWagon" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 4,
                columns: new[] { "vehicleDescription", "vehicleType" },
                values: new object[] { "Rem esse nisi minima suscipit rerum quae eligendi ullam nam. Architecto reprehenderit quia laudantium et accusamus tempore eos. Occaecati non eos quod in. Nemo natus optio.", "Sedan" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 5,
                columns: new[] { "VendorID", "vehicleDescription", "vehicleType" },
                values: new object[] { 1, "Et ratione unde quia veritatis. Et quidem nemo beatae aperiam neque. Et sint vero.", "Sedan" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 6,
                columns: new[] { "VendorID", "vehicleDescription", "vehicleType" },
                values: new object[] { 2, "Nostrum voluptatem accusantium consequuntur dolorum ab rerum illo est cum. Eveniet doloribus perspiciatis velit sint repellendus non doloribus ipsam quo. Excepturi omnis sed cupiditate neque. Ad labore odit id.", "Shitbox" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 7,
                columns: new[] { "vehicleDescription", "vehicleType" },
                values: new object[] { "Minima harum qui. Esse quo aperiam. Accusantium iure aliquid. Aperiam eos est et.", "Ute" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 8,
                columns: new[] { "VendorID", "vehicleDescription", "vehicleType" },
                values: new object[] { 2, "Molestiae et quia. Et ratione minus impedit qui. Assumenda sunt optio eum eius qui. Magnam ut recusandae amet animi quam officiis omnis tenetur esse.", "HatchBack" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 9,
                columns: new[] { "VendorID", "vehicleDescription", "vehicleType" },
                values: new object[] { 2, "Aperiam corrupti natus quam eos ut reiciendis quibusdam debitis reiciendis. Est excepturi nesciunt a illo officiis sit ipsa esse expedita. Dolor tempore veniam quas enim. Aut delectus fugit eum repellendus officiis cumque occaecati. Ut natus velit autem similique aut laborum. Unde error cupiditate dolore omnis nihil assumenda quod.", "Shitbox" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 10,
                columns: new[] { "VendorID", "vehicleDescription", "vehicleType" },
                values: new object[] { 1, "Tempore beatae ex placeat ipsam quis vero. Velit quo nobis animi qui reprehenderit et. Tenetur minus harum ea dignissimos recusandae tempora cupiditate quo. Laborum ad eos quo aliquam voluptatem voluptatem omnis expedita. Quaerat non atque necessitatibus omnis dicta nesciunt sed vitae. Quae quasi ullam et.", "Sedan" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 11,
                columns: new[] { "vehicleDescription", "vehicleType" },
                values: new object[] { "Voluptatibus quidem quasi voluptas provident. Maiores ut et est ullam inventore possimus molestiae. Minima adipisci iusto alias repudiandae et inventore cum quia nesciunt. Necessitatibus illo et harum maxime doloribus enim provident.", "Ute" });

            migrationBuilder.UpdateData(
                table: "Vendor",
                keyColumn: "VendorID",
                keyValue: 2,
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Tenetur nam voluptas nobis voluptates quas iste ut nulla.", "043 Osinski Mission", "Unlimited Problems Ltd." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 1,
                columns: new[] { "FoodDescription", "FoodType", "VendorID" },
                values: new object[] { "Sunt voluptates velit dolorum.", "Beverage", 2 });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 2,
                columns: new[] { "FoodDescription", "FoodType" },
                values: new object[] { "Autem molestiae quis voluptatem pariatur ut.", "Cake" });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 3,
                columns: new[] { "FoodDescription", "FoodType", "VendorID" },
                values: new object[] { "Quis eveniet perspiciatis dolorum quia.", "Cake", 2 });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 4,
                columns: new[] { "FoodDescription", "FoodType", "VendorID" },
                values: new object[] { "Ullam aut officiis deleniti commodi.", "Muffin", 1 });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 5,
                columns: new[] { "FoodDescription", "FoodType", "VendorID" },
                values: new object[] { "Reiciendis aut culpa tenetur et tempora sed quo maiores.", "Muffin", 2 });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 6,
                columns: new[] { "FoodDescription", "FoodType", "VendorID" },
                values: new object[] { "Laborum eum ipsam.", "Cake", 2 });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 7,
                columns: new[] { "FoodDescription", "FoodType", "VendorID" },
                values: new object[] { "Animi architecto est.", "Breads", 1 });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 8,
                column: "FoodDescription",
                value: "Vel nisi modi sit maxime maxime sunt.");

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 9,
                columns: new[] { "FoodDescription", "FoodType", "VendorID" },
                values: new object[] { "Ab repudiandae voluptatem magni debitis sed iure laboriosam incidunt.", "Burger", 1 });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 10,
                columns: new[] { "FoodDescription", "FoodType", "VendorID" },
                values: new object[] { "Est alias sed magnam reiciendis voluptas.", "Cupcake", 2 });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 11,
                columns: new[] { "FoodDescription", "FoodType", "VendorID" },
                values: new object[] { "Distinctio error voluptas fuga iusto harum necessitatibus quo.", "Beverage", 2 });

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "furnitureID",
                keyValue: 1,
                columns: new[] { "furnitureDescription", "furnitureType" },
                values: new object[] { "Temporibus eaque assumenda expedita voluptates animi magnam vero consequuntur cum.", "Chair" });

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "furnitureID",
                keyValue: 2,
                columns: new[] { "VendorID", "furnitureDescription", "furnitureType" },
                values: new object[] { 1, "Reiciendis sed est sed labore aut qui quisquam quia quia.", "Bed" });

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "furnitureID",
                keyValue: 3,
                columns: new[] { "VendorID", "furnitureDescription", "furnitureType" },
                values: new object[] { 1, "Dolores vel a blanditiis ex eveniet corrupti autem et unde.", "Chair" });

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "furnitureID",
                keyValue: 4,
                columns: new[] { "VendorID", "furnitureDescription", "furnitureType" },
                values: new object[] { 2, "Enim placeat dolorem sapiente.", "Bed" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 1,
                columns: new[] { "VendorID", "vehicleDescription", "vehicleType" },
                values: new object[] { 1, "Autem sit beatae. Deleniti quis officia architecto. Possimus consectetur ipsum. Sapiente cumque qui quod qui atque et vero enim.", "StationWagon" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 2,
                columns: new[] { "VendorID", "vehicleDescription" },
                values: new object[] { 2, "Doloremque libero placeat nihil accusamus autem sit placeat. Autem nobis totam. Repudiandae voluptatum aut blanditiis dolor nihil alias. Natus sunt quaerat est aut cupiditate reprehenderit vitae provident." });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 3,
                columns: new[] { "VendorID", "vehicleDescription", "vehicleType" },
                values: new object[] { 2, "Quia voluptas ut corrupti ex maxime. Itaque non qui modi sed architecto eveniet ullam. Ab illo illum explicabo eveniet tempore.", "Shitbox" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 4,
                columns: new[] { "vehicleDescription", "vehicleType" },
                values: new object[] { "Non nesciunt dolore minima placeat. Rerum eum enim at modi qui voluptatibus ut maxime quidem. Consequuntur enim esse sint accusamus. Non ipsam et libero.", "Shitbox" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 5,
                columns: new[] { "VendorID", "vehicleDescription", "vehicleType" },
                values: new object[] { 2, "Odio sit assumenda cupiditate sunt corrupti blanditiis saepe voluptatem. Adipisci ullam officia qui magnam similique debitis quia ipsam expedita. Rerum perferendis molestiae sunt occaecati. Et aliquam qui quas.", "StationWagon" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 6,
                columns: new[] { "VendorID", "vehicleDescription", "vehicleType" },
                values: new object[] { 1, "Ut et similique laudantium temporibus. Magni iure qui recusandae sit magni. Vero voluptatem quis et repudiandae et mollitia eaque.", "HatchBack" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 7,
                columns: new[] { "vehicleDescription", "vehicleType" },
                values: new object[] { "Doloribus delectus ad sunt. Qui deserunt illum magnam soluta facilis ab error est ipsum. Eius exercitationem aut rerum id vitae cupiditate.", "HatchBack" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 8,
                columns: new[] { "VendorID", "vehicleDescription", "vehicleType" },
                values: new object[] { 1, "Dolore dolore numquam doloribus est blanditiis maiores consequatur quia. Repellat provident quia nihil reiciendis at quia non ut placeat. Corrupti in voluptates ipsum repellendus facilis. Voluptas voluptatem voluptatibus autem corporis ea dolorem vel.", "StationWagon" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 9,
                columns: new[] { "VendorID", "vehicleDescription", "vehicleType" },
                values: new object[] { 1, "Omnis quaerat et amet. Voluptatem amet tenetur at. Tenetur reprehenderit et delectus nostrum et.", "Sedan" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 10,
                columns: new[] { "VendorID", "vehicleDescription", "vehicleType" },
                values: new object[] { 2, "Facilis quis qui odit. Ratione accusamus debitis dolorum sed reprehenderit dignissimos voluptas distinctio cumque. Maiores ipsam non voluptatem voluptatem laborum. Sed a vero quia est consectetur natus dolor molestiae ullam.", "StationWagon" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 11,
                columns: new[] { "vehicleDescription", "vehicleType" },
                values: new object[] { "Accusantium maxime vero. Exercitationem dolorum vel omnis qui et aut aliquam deleniti cupiditate. Quia recusandae eaque. Neque voluptatem consequatur quo veniam impedit porro praesentium.", "HatchBack" });

            migrationBuilder.UpdateData(
                table: "Vendor",
                keyColumn: "VendorID",
                keyValue: 2,
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Sint autem sunt quia quia ea delectus saepe.", "234 Adelbert Glens", "Metabolic sustenance" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "VendorID", "Description", "Location", "Name" },
                values: new object[] { 1, "Voluptates dolore consectetur autem.", "910 Langworth Circles", "ElixirPrime Group" });
        }
    }
}
