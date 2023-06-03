using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendAPI.Migrations
{
    public partial class _14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 1,
                columns: new[] { "FoodDescription", "FoodType", "VendorID" },
                values: new object[] { "Impedit quia enim et.", "Beverage", 2 });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 2,
                columns: new[] { "FoodDescription", "FoodType" },
                values: new object[] { "Voluptatibus recusandae dolorem omnis praesentium.", "Muffin" });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 3,
                columns: new[] { "FoodDescription", "FoodType" },
                values: new object[] { "Non id in.", "Cake" });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 4,
                columns: new[] { "FoodDescription", "FoodType", "VendorID" },
                values: new object[] { "Quibusdam fugiat eaque quasi ipsum alias quisquam impedit id.", "Beverage", 1 });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 5,
                columns: new[] { "FoodDescription", "FoodType" },
                values: new object[] { "Nam voluptatem in qui.", "Cake" });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 6,
                columns: new[] { "FoodDescription", "FoodType", "VendorID" },
                values: new object[] { "Pariatur ut dolor quae necessitatibus.", "Breads", 2 });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 7,
                columns: new[] { "FoodDescription", "FoodType" },
                values: new object[] { "Est odit aut a.", "Beverage" });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 8,
                columns: new[] { "FoodDescription", "FoodType" },
                values: new object[] { "Recusandae aliquid debitis aliquam quaerat nam molestiae.", "Burger" });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 9,
                columns: new[] { "FoodDescription", "FoodType" },
                values: new object[] { "Omnis et inventore nobis quam cum omnis id non ut.", "Snack" });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 10,
                columns: new[] { "FoodDescription", "FoodType" },
                values: new object[] { "Quo eos est sit facere exercitationem.", "Cupcake" });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 11,
                column: "FoodDescription",
                value: "Quis unde omnis.");

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "furnitureID",
                keyValue: 1,
                columns: new[] { "VendorID", "furnitureDescription" },
                values: new object[] { 1, "Praesentium rerum illo ea minus dolores amet." });

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "furnitureID",
                keyValue: 2,
                columns: new[] { "furnitureDescription", "furnitureType" },
                values: new object[] { "Quisquam aut vel eveniet consectetur corrupti.", "Occasional Furniture" });

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "furnitureID",
                keyValue: 3,
                columns: new[] { "furnitureDescription", "furnitureType" },
                values: new object[] { "Voluptatum quas dolorum vel et sed.", "Bed" });

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "furnitureID",
                keyValue: 4,
                column: "furnitureDescription",
                value: "Ut dolorum unde maxime cum laudantium exercitationem.");

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 1,
                columns: new[] { "VendorID", "vehicleDescription", "vehicleType" },
                values: new object[] { 1, "Sed a suscipit ad similique quae molestiae nihil et voluptatem. Aut et aperiam. Vel ipsa commodi totam provident est et non fugiat magnam. Omnis occaecati omnis commodi ut atque vel enim vero minus. Quia rerum expedita id dolore. Illum suscipit non consequuntur vitae quia quam.", "StationWagon" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 2,
                columns: new[] { "vehicleDescription", "vehicleType" },
                values: new object[] { "Deserunt quidem itaque est sint. Ratione incidunt quis. In praesentium sit minima vero at ut. Omnis tempora facilis nisi.", "Ute" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 3,
                columns: new[] { "vehicleDescription", "vehicleType" },
                values: new object[] { "Amet iste sunt voluptas velit rem quisquam. Voluptates eligendi itaque ratione omnis asperiores vero voluptatum harum. Est harum ducimus distinctio suscipit dolor autem. Natus voluptatem doloremque doloremque et cumque maxime et. Error molestias delectus. Illum amet libero vel voluptas iure reiciendis.", "Ute" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 4,
                columns: new[] { "VendorID", "vehicleDescription", "vehicleType" },
                values: new object[] { 2, "Dolorum corporis harum ipsa alias. Error minima in fuga fuga quis deleniti corrupti et. Voluptatum quasi nemo ea. Sapiente voluptatum pariatur quidem adipisci nihil ut quidem ut aut.", "Ute" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 5,
                columns: new[] { "VendorID", "vehicleDescription", "vehicleType" },
                values: new object[] { 2, "Eum non dolores. Eius vel minus nemo eius voluptas laboriosam tenetur accusantium. Dolor eum soluta non consequatur.", "Shitbox" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 6,
                columns: new[] { "VendorID", "vehicleDescription" },
                values: new object[] { 1, "Odit quam qui nostrum corporis numquam. Aut voluptates doloremque ut quis sit eos. Vero itaque est quas impedit ut aliquam. Neque deserunt qui autem eaque. Nostrum nihil eum perferendis provident quas." });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 7,
                columns: new[] { "VendorID", "vehicleDescription" },
                values: new object[] { 2, "Facere aut sit sint aut aut voluptas cupiditate ipsam. Molestias dolor repellat iste non labore nostrum atque. Ratione ratione commodi similique impedit autem. Quia error dolorem optio voluptatem ducimus. Omnis et omnis sint neque voluptates. Sint est qui." });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 8,
                columns: new[] { "vehicleDescription", "vehicleType" },
                values: new object[] { "Necessitatibus quia totam aut tempora. Nostrum eum aut. Ut fugiat aperiam pariatur magnam qui debitis odit ut perferendis.", "StationWagon" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 9,
                columns: new[] { "vehicleDescription", "vehicleType" },
                values: new object[] { "Tenetur animi eaque reiciendis labore iusto et id consequatur. Quam commodi tempora architecto saepe omnis voluptatem exercitationem est sint. Suscipit tenetur enim repellat aut explicabo.", "Ute" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 10,
                columns: new[] { "vehicleDescription", "vehicleType" },
                values: new object[] { "Sed similique assumenda dignissimos et et incidunt qui sint. Est maxime repellat nisi voluptas consequatur nam repellendus. Consequatur quis animi. Deserunt saepe sed rerum. Deserunt tempora cupiditate quae iste ea quia.", "Ute" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 11,
                columns: new[] { "vehicleDescription", "vehicleType" },
                values: new object[] { "Sint praesentium aliquid dolorum suscipit quia. Ab omnis officia eum harum est distinctio. Nobis et tenetur quas est natus omnis saepe non. Ut iste qui. Eaque est sed officiis aut nihil ex ut. Voluptatem qui sunt sequi pariatur quas officia.", "HatchBack" });

            migrationBuilder.UpdateData(
                table: "Vendor",
                keyColumn: "VendorID",
                keyValue: 2,
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Culpa et consequatur deleniti modi eveniet officia.", "68107 Schuppe Prairie", "ElixirPrime Group" });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "VendorID", "Description", "Location", "Name" },
                values: new object[] { 1, "Tempora recusandae repellat sint autem fugiat consequuntur et ducimus ducimus.", "1079 Selmer Drive", "NovaGlobe Enterprises" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "FoodDescription", "FoodType" },
                values: new object[] { "Sint ea quia et culpa.", "Muffin" });

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
                columns: new[] { "FoodDescription", "FoodType" },
                values: new object[] { "Consectetur minus doloribus rerum minima totam modi et sunt.", "Burger" });

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
                columns: new[] { "FoodDescription", "FoodType" },
                values: new object[] { "Incidunt libero vel.", "Cupcake" });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 8,
                columns: new[] { "FoodDescription", "FoodType" },
                values: new object[] { "Natus aut qui et.", "Beverage" });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 9,
                columns: new[] { "FoodDescription", "FoodType" },
                values: new object[] { "Est est eius commodi accusamus velit quibusdam.", "Breads" });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 10,
                columns: new[] { "FoodDescription", "FoodType" },
                values: new object[] { "Quisquam pariatur quia.", "Beverage" });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 11,
                column: "FoodDescription",
                value: "Ea minus saepe quas nobis aut earum.");

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "furnitureID",
                keyValue: 1,
                columns: new[] { "VendorID", "furnitureDescription" },
                values: new object[] { 2, "Est occaecati iusto blanditiis." });

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "furnitureID",
                keyValue: 2,
                columns: new[] { "furnitureDescription", "furnitureType" },
                values: new object[] { "Rem magnam deleniti eum officiis sed.", "Couch" });

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "furnitureID",
                keyValue: 3,
                columns: new[] { "furnitureDescription", "furnitureType" },
                values: new object[] { "Non consequatur eaque molestias asperiores animi in explicabo.", "Couch" });

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "furnitureID",
                keyValue: 4,
                column: "furnitureDescription",
                value: "Nihil possimus quas aut quae velit ut veniam sint.");

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
                columns: new[] { "vehicleDescription", "vehicleType" },
                values: new object[] { "Modi numquam et nobis ipsum voluptas. Nobis aspernatur facilis assumenda qui reiciendis. Omnis suscipit perspiciatis et iste. Animi impedit impedit repudiandae labore fugiat.", "Shitbox" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 3,
                columns: new[] { "vehicleDescription", "vehicleType" },
                values: new object[] { "Velit voluptatem ea accusamus non et quasi animi qui. Ratione est rerum. Expedita omnis et et. Error doloremque quod ut velit facere ad.", "StationWagon" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 4,
                columns: new[] { "VendorID", "vehicleDescription", "vehicleType" },
                values: new object[] { 1, "Rem esse nisi minima suscipit rerum quae eligendi ullam nam. Architecto reprehenderit quia laudantium et accusamus tempore eos. Occaecati non eos quod in. Nemo natus optio.", "Sedan" });

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
                columns: new[] { "VendorID", "vehicleDescription" },
                values: new object[] { 2, "Nostrum voluptatem accusantium consequuntur dolorum ab rerum illo est cum. Eveniet doloribus perspiciatis velit sint repellendus non doloribus ipsam quo. Excepturi omnis sed cupiditate neque. Ad labore odit id." });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 7,
                columns: new[] { "VendorID", "vehicleDescription" },
                values: new object[] { 1, "Minima harum qui. Esse quo aperiam. Accusantium iure aliquid. Aperiam eos est et." });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 8,
                columns: new[] { "vehicleDescription", "vehicleType" },
                values: new object[] { "Molestiae et quia. Et ratione minus impedit qui. Assumenda sunt optio eum eius qui. Magnam ut recusandae amet animi quam officiis omnis tenetur esse.", "HatchBack" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 9,
                columns: new[] { "vehicleDescription", "vehicleType" },
                values: new object[] { "Aperiam corrupti natus quam eos ut reiciendis quibusdam debitis reiciendis. Est excepturi nesciunt a illo officiis sit ipsa esse expedita. Dolor tempore veniam quas enim. Aut delectus fugit eum repellendus officiis cumque occaecati. Ut natus velit autem similique aut laborum. Unde error cupiditate dolore omnis nihil assumenda quod.", "Shitbox" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 10,
                columns: new[] { "vehicleDescription", "vehicleType" },
                values: new object[] { "Tempore beatae ex placeat ipsam quis vero. Velit quo nobis animi qui reprehenderit et. Tenetur minus harum ea dignissimos recusandae tempora cupiditate quo. Laborum ad eos quo aliquam voluptatem voluptatem omnis expedita. Quaerat non atque necessitatibus omnis dicta nesciunt sed vitae. Quae quasi ullam et.", "Sedan" });

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
    }
}
