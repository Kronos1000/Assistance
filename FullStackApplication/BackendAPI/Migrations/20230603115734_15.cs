using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendAPI.Migrations
{
    public partial class _15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 1,
                columns: new[] { "FoodDescription", "FoodType" },
                values: new object[] { "Modi praesentium reiciendis veritatis est iusto ratione dolore.", "Cake" });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 2,
                columns: new[] { "FoodDescription", "FoodType" },
                values: new object[] { "Exercitationem quia doloribus et ea et quidem voluptatum.", "Burger" });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 3,
                columns: new[] { "FoodDescription", "FoodType" },
                values: new object[] { "Rem et dolore omnis consequatur accusamus.", "Cupcake" });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 4,
                columns: new[] { "FoodDescription", "FoodType" },
                values: new object[] { "Quos blanditiis officiis voluptatem odio non iusto dolor.", "Cupcake" });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 5,
                columns: new[] { "FoodDescription", "FoodType" },
                values: new object[] { "Magni necessitatibus qui atque temporibus placeat in.", "Snack" });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 6,
                columns: new[] { "FoodDescription", "FoodType" },
                values: new object[] { "Maiores culpa consequatur totam cupiditate recusandae.", "Cake" });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 7,
                columns: new[] { "FoodDescription", "FoodType" },
                values: new object[] { "Aut rem deserunt fugit quisquam non.", "Cupcake" });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 8,
                columns: new[] { "FoodDescription", "FoodType" },
                values: new object[] { "Ab architecto iste vero rerum voluptatem.", "Snack" });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 9,
                columns: new[] { "FoodDescription", "FoodType", "VendorID" },
                values: new object[] { "Non qui aut quia enim eligendi et fugiat quasi et.", "Beverage", 1 });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 10,
                columns: new[] { "FoodDescription", "FoodType", "VendorID" },
                values: new object[] { "Et ea aliquid omnis placeat.", "Burger", 2 });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 11,
                columns: new[] { "FoodDescription", "FoodType", "VendorID" },
                values: new object[] { "Aut voluptas ad laboriosam iure in.", "Beverage", 2 });

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "furnitureID",
                keyValue: 1,
                columns: new[] { "furnitureDescription", "furnitureType" },
                values: new object[] { "In dignissimos id.", "Occasional Furniture" });

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "furnitureID",
                keyValue: 2,
                columns: new[] { "furnitureDescription", "furnitureType" },
                values: new object[] { "Et repudiandae voluptatem sit odio aut laboriosam.", "Couch" });

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "furnitureID",
                keyValue: 3,
                columns: new[] { "furnitureDescription", "furnitureType" },
                values: new object[] { "Sed iure omnis quibusdam.", "Occasional Furniture" });

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "furnitureID",
                keyValue: 4,
                column: "furnitureDescription",
                value: "Et placeat minima et dolor et.");

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
                column: "vehicleDescription",
                value: "Sed dolores consequuntur quia fugiat distinctio. Ut quia voluptatem. Similique aut in libero facere. Dicta at est. Non autem debitis aliquid est nam cupiditate laboriosam magnam.");

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 3,
                columns: new[] { "VendorID", "vehicleDescription", "vehicleType" },
                values: new object[] { 2, "Expedita voluptates natus ad vel sed sed earum nemo voluptatem. Corrupti ex nobis optio perspiciatis et dolorem. Rerum quasi ipsa occaecati incidunt distinctio laboriosam. Ipsam repellendus repellendus suscipit nesciunt sint ut in consequatur. Est nihil quia. Ut vel nobis iste eum fugiat.", "Sedan" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 4,
                columns: new[] { "VendorID", "vehicleDescription", "vehicleType" },
                values: new object[] { 1, "Eos ipsum voluptatem ullam nihil aut aliquid voluptatem. Qui numquam quia repellendus. Est et eum et consequatur in dolore.", "StationWagon" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 5,
                columns: new[] { "VendorID", "vehicleDescription", "vehicleType" },
                values: new object[] { 1, "Ratione non ipsum. Molestiae ut voluptates vel voluptatem quibusdam. Tempore illo architecto et voluptas ut voluptatem aut delectus similique. Officiis esse sunt aut minus molestiae sed quasi. Voluptatem voluptates possimus harum in.", "Sedan" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 6,
                columns: new[] { "vehicleDescription", "vehicleType" },
                values: new object[] { "Dolor minus laboriosam consectetur voluptas ut qui molestiae. Sit accusamus corrupti repudiandae consequatur fuga at sit ut eum. Ipsum animi animi tempora. Mollitia est sit dolores ducimus nisi quia.", "Ute" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 7,
                columns: new[] { "VendorID", "vehicleDescription" },
                values: new object[] { 1, "Nobis hic odit ut dolores in sapiente. Esse aut delectus est ex. Et autem et qui officiis quibusdam ullam. Aspernatur quia dolores porro quasi optio." });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 8,
                columns: new[] { "vehicleDescription", "vehicleType" },
                values: new object[] { "Eum sed dicta similique aut. Dicta quis est ipsum quidem ducimus consequatur. Qui voluptatem tempora consequatur ad aut provident. Porro quam error. Iure quo est nulla. Officia dolores aut et dolorem qui officia quasi maxime et.", "Shitbox" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 9,
                columns: new[] { "VendorID", "vehicleDescription", "vehicleType" },
                values: new object[] { 1, "Suscipit facilis repellat in in. Unde aut sed aut cumque. Aut quibusdam ullam quis. Velit dolores qui. Est similique aliquid officia.", "Shitbox" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 10,
                columns: new[] { "vehicleDescription", "vehicleType" },
                values: new object[] { "Pariatur ut culpa laborum odit qui. Recusandae rerum veniam possimus. Enim accusantium porro et nihil officia. Modi accusamus quibusdam suscipit nisi earum quas ullam fuga.", "HatchBack" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 11,
                columns: new[] { "vehicleDescription", "vehicleType" },
                values: new object[] { "Aspernatur nisi est. Ipsam vero culpa. Repellat esse minima. Qui quia maiores natus.", "StationWagon" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 1,
                columns: new[] { "FoodDescription", "FoodType" },
                values: new object[] { "Impedit quia enim et.", "Beverage" });

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
                columns: new[] { "FoodDescription", "FoodType" },
                values: new object[] { "Quibusdam fugiat eaque quasi ipsum alias quisquam impedit id.", "Beverage" });

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
                columns: new[] { "FoodDescription", "FoodType" },
                values: new object[] { "Pariatur ut dolor quae necessitatibus.", "Breads" });

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
                columns: new[] { "FoodDescription", "FoodType", "VendorID" },
                values: new object[] { "Omnis et inventore nobis quam cum omnis id non ut.", "Snack", 2 });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 10,
                columns: new[] { "FoodDescription", "FoodType", "VendorID" },
                values: new object[] { "Quo eos est sit facere exercitationem.", "Cupcake", 1 });

            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 11,
                columns: new[] { "FoodDescription", "FoodType", "VendorID" },
                values: new object[] { "Quis unde omnis.", "Breads", 1 });

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "furnitureID",
                keyValue: 1,
                columns: new[] { "furnitureDescription", "furnitureType" },
                values: new object[] { "Praesentium rerum illo ea minus dolores amet.", "Bed" });

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
                column: "vehicleDescription",
                value: "Deserunt quidem itaque est sint. Ratione incidunt quis. In praesentium sit minima vero at ut. Omnis tempora facilis nisi.");

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "vehicleID",
                keyValue: 3,
                columns: new[] { "VendorID", "vehicleDescription", "vehicleType" },
                values: new object[] { 1, "Amet iste sunt voluptas velit rem quisquam. Voluptates eligendi itaque ratione omnis asperiores vero voluptatum harum. Est harum ducimus distinctio suscipit dolor autem. Natus voluptatem doloremque doloremque et cumque maxime et. Error molestias delectus. Illum amet libero vel voluptas iure reiciendis.", "Ute" });

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
                columns: new[] { "vehicleDescription", "vehicleType" },
                values: new object[] { "Odit quam qui nostrum corporis numquam. Aut voluptates doloremque ut quis sit eos. Vero itaque est quas impedit ut aliquam. Neque deserunt qui autem eaque. Nostrum nihil eum perferendis provident quas.", "Shitbox" });

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
                columns: new[] { "VendorID", "vehicleDescription", "vehicleType" },
                values: new object[] { 2, "Tenetur animi eaque reiciendis labore iusto et id consequatur. Quam commodi tempora architecto saepe omnis voluptatem exercitationem est sint. Suscipit tenetur enim repellat aut explicabo.", "Ute" });

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
                keyValue: 1,
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Tempora recusandae repellat sint autem fugiat consequuntur et ducimus ducimus.", "1079 Selmer Drive", "NovaGlobe Enterprises" });

            migrationBuilder.UpdateData(
                table: "Vendor",
                keyColumn: "VendorID",
                keyValue: 2,
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Culpa et consequatur deleniti modi eveniet officia.", "68107 Schuppe Prairie", "ElixirPrime Group" });
        }
    }
}
