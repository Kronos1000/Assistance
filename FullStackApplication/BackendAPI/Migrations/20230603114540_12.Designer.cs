﻿// <auto-generated />
using BackendAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BackendAPI.Migrations
{
    [DbContext(typeof(BackendAPIContext))]
    [Migration("20230603114540_12")]
    partial class _12
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BackendAPI.Models.Food", b =>
                {
                    b.Property<int>("FoodID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FoodID"), 1L, 1);

                    b.Property<string>("FoodDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FoodName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FoodType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VendorID")
                        .HasColumnType("int");

                    b.HasKey("FoodID");

                    b.ToTable("Food");

                    b.HasData(
                        new
                        {
                            FoodID = 1,
                            FoodDescription = "Sunt voluptates velit dolorum.",
                            FoodName = "Aspestos Flavoured sausages",
                            FoodType = "Beverage",
                            VendorID = 2
                        },
                        new
                        {
                            FoodID = 2,
                            FoodDescription = "Autem molestiae quis voluptatem pariatur ut.",
                            FoodName = "Bacon Flavoured Icecream",
                            FoodType = "Cake",
                            VendorID = 1
                        },
                        new
                        {
                            FoodID = 3,
                            FoodDescription = "Quis eveniet perspiciatis dolorum quia.",
                            FoodName = "Mac and Cheese Filled Doughnuts",
                            FoodType = "Cake",
                            VendorID = 2
                        },
                        new
                        {
                            FoodID = 4,
                            FoodDescription = "Ullam aut officiis deleniti commodi.",
                            FoodName = "frostly Flakes Flavoured Milk",
                            FoodType = "Muffin",
                            VendorID = 1
                        },
                        new
                        {
                            FoodID = 5,
                            FoodDescription = "Reiciendis aut culpa tenetur et tempora sed quo maiores.",
                            FoodName = "Plastic Cheese Burger",
                            FoodType = "Muffin",
                            VendorID = 2
                        },
                        new
                        {
                            FoodID = 6,
                            FoodDescription = "Laborum eum ipsam.",
                            FoodName = "Apple pie arsenic surpise",
                            FoodType = "Cake",
                            VendorID = 2
                        },
                        new
                        {
                            FoodID = 7,
                            FoodDescription = "Animi architecto est.",
                            FoodName = "A Warm Apple pie",
                            FoodType = "Breads",
                            VendorID = 1
                        },
                        new
                        {
                            FoodID = 8,
                            FoodDescription = "Vel nisi modi sit maxime maxime sunt.",
                            FoodName = "Cardboard Pizza",
                            FoodType = "Beverage",
                            VendorID = 1
                        },
                        new
                        {
                            FoodID = 9,
                            FoodDescription = "Ab repudiandae voluptatem magni debitis sed iure laboriosam incidunt.",
                            FoodName = "Chocolate Cake",
                            FoodType = "Burger",
                            VendorID = 1
                        },
                        new
                        {
                            FoodID = 10,
                            FoodDescription = "Est alias sed magnam reiciendis voluptas.",
                            FoodName = "Live Plus Energy Drink",
                            FoodType = "Cupcake",
                            VendorID = 2
                        },
                        new
                        {
                            FoodID = 11,
                            FoodDescription = "Distinctio error voluptas fuga iusto harum necessitatibus quo.",
                            FoodName = "Oliver's Favorite Food",
                            FoodType = "Beverage",
                            VendorID = 2
                        });
                });

            modelBuilder.Entity("BackendAPI.Models.Furniture", b =>
                {
                    b.Property<int>("furnitureID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("furnitureID"), 1L, 1);

                    b.Property<int>("VendorID")
                        .HasColumnType("int");

                    b.Property<string>("furnitureDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("furnitureName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("furnitureType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("furnitureID");

                    b.ToTable("Furniture");

                    b.HasData(
                        new
                        {
                            furnitureID = 1,
                            VendorID = 2,
                            furnitureDescription = "Temporibus eaque assumenda expedita voluptates animi magnam vero consequuntur cum.",
                            furnitureName = "Thrustmaster 1000",
                            furnitureType = "Chair"
                        },
                        new
                        {
                            furnitureID = 2,
                            VendorID = 1,
                            furnitureDescription = "Reiciendis sed est sed labore aut qui quisquam quia quia.",
                            furnitureName = "The Pull Out",
                            furnitureType = "Bed"
                        },
                        new
                        {
                            furnitureID = 3,
                            VendorID = 1,
                            furnitureDescription = "Dolores vel a blanditiis ex eveniet corrupti autem et unde.",
                            furnitureName = "The waterbed",
                            furnitureType = "Chair"
                        },
                        new
                        {
                            furnitureID = 4,
                            VendorID = 2,
                            furnitureDescription = "Enim placeat dolorem sapiente.",
                            furnitureName = "regretabed",
                            furnitureType = "Bed"
                        });
                });

            modelBuilder.Entity("BackendAPI.Models.Vehicle", b =>
                {
                    b.Property<int>("vehicleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("vehicleID"), 1L, 1);

                    b.Property<int>("VendorID")
                        .HasColumnType("int");

                    b.Property<string>("vehicleDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("vehicleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("vehicleType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("vehicleID");

                    b.ToTable("Vehicle");

                    b.HasData(
                        new
                        {
                            vehicleID = 1,
                            VendorID = 1,
                            vehicleDescription = "Autem sit beatae. Deleniti quis officia architecto. Possimus consectetur ipsum. Sapiente cumque qui quod qui atque et vero enim.",
                            vehicleName = "Honda Del Sol",
                            vehicleType = "StationWagon"
                        },
                        new
                        {
                            vehicleID = 2,
                            VendorID = 2,
                            vehicleDescription = "Doloremque libero placeat nihil accusamus autem sit placeat. Autem nobis totam. Repudiandae voluptatum aut blanditiis dolor nihil alias. Natus sunt quaerat est aut cupiditate reprehenderit vitae provident.",
                            vehicleName = "Honda Accord",
                            vehicleType = "Shitbox"
                        },
                        new
                        {
                            vehicleID = 3,
                            VendorID = 2,
                            vehicleDescription = "Quia voluptas ut corrupti ex maxime. Itaque non qui modi sed architecto eveniet ullam. Ab illo illum explicabo eveniet tempore.",
                            vehicleName = "Holden Crewman  S",
                            vehicleType = "Shitbox"
                        },
                        new
                        {
                            vehicleID = 4,
                            VendorID = 1,
                            vehicleDescription = "Non nesciunt dolore minima placeat. Rerum eum enim at modi qui voluptatibus ut maxime quidem. Consequuntur enim esse sint accusamus. Non ipsam et libero.",
                            vehicleName = "Holden Crewman SS",
                            vehicleType = "Shitbox"
                        },
                        new
                        {
                            vehicleID = 5,
                            VendorID = 2,
                            vehicleDescription = "Odio sit assumenda cupiditate sunt corrupti blanditiis saepe voluptatem. Adipisci ullam officia qui magnam similique debitis quia ipsam expedita. Rerum perferendis molestiae sunt occaecati. Et aliquam qui quas.",
                            vehicleName = "Nissan Tiida Latio",
                            vehicleType = "StationWagon"
                        },
                        new
                        {
                            vehicleID = 6,
                            VendorID = 1,
                            vehicleDescription = "Ut et similique laudantium temporibus. Magni iure qui recusandae sit magni. Vero voluptatem quis et repudiandae et mollitia eaque.",
                            vehicleName = "Mazda Verisa",
                            vehicleType = "HatchBack"
                        },
                        new
                        {
                            vehicleID = 7,
                            VendorID = 1,
                            vehicleDescription = "Doloribus delectus ad sunt. Qui deserunt illum magnam soluta facilis ab error est ipsum. Eius exercitationem aut rerum id vitae cupiditate.",
                            vehicleName = "Ford Falcon FG XR6",
                            vehicleType = "HatchBack"
                        },
                        new
                        {
                            vehicleID = 8,
                            VendorID = 1,
                            vehicleDescription = "Dolore dolore numquam doloribus est blanditiis maiores consequatur quia. Repellat provident quia nihil reiciendis at quia non ut placeat. Corrupti in voluptates ipsum repellendus facilis. Voluptas voluptatem voluptatibus autem corporis ea dolorem vel.",
                            vehicleName = "Ford Falcon BA XR8",
                            vehicleType = "StationWagon"
                        },
                        new
                        {
                            vehicleID = 9,
                            VendorID = 1,
                            vehicleDescription = "Omnis quaerat et amet. Voluptatem amet tenetur at. Tenetur reprehenderit et delectus nostrum et.",
                            vehicleName = "Nissan Cefiro",
                            vehicleType = "Sedan"
                        },
                        new
                        {
                            vehicleID = 10,
                            VendorID = 2,
                            vehicleDescription = "Facilis quis qui odit. Ratione accusamus debitis dolorum sed reprehenderit dignissimos voluptas distinctio cumque. Maiores ipsam non voluptatem voluptatem laborum. Sed a vero quia est consectetur natus dolor molestiae ullam.",
                            vehicleName = "Nissan Stagea",
                            vehicleType = "StationWagon"
                        },
                        new
                        {
                            vehicleID = 11,
                            VendorID = 1,
                            vehicleDescription = "Accusantium maxime vero. Exercitationem dolorum vel omnis qui et aut aliquam deleniti cupiditate. Quia recusandae eaque. Neque voluptatem consequatur quo veniam impedit porro praesentium.",
                            vehicleName = "Subaru WRX",
                            vehicleType = "HatchBack"
                        });
                });

            modelBuilder.Entity("BackendAPI.Models.Vendor", b =>
                {
                    b.Property<int>("VendorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VendorID"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VendorID");

                    b.ToTable("Vendor");

                    b.HasData(
                        new
                        {
                            VendorID = 1,
                            Description = "Voluptates dolore consectetur autem.",
                            Location = "910 Langworth Circles",
                            Name = "ElixirPrime Group"
                        },
                        new
                        {
                            VendorID = 2,
                            Description = "Sint autem sunt quia quia ea delectus saepe.",
                            Location = "234 Adelbert Glens",
                            Name = "Metabolic sustenance"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}