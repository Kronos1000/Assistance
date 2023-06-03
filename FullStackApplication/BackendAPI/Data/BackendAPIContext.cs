using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BackendAPI.Models;
using Bogus;

namespace BackendAPI.Data
{
    public class BackendAPIContext : DbContext
    {
        public BackendAPIContext(DbContextOptions<BackendAPIContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Random RandVendor = new Random();

            int vCount = 3;

            var Faker = new Bogus.Faker();

            // Generate Array for random data seeding
            string[] ranFoodTypeArray = { "Cake", "Burger", "Muffin", "Cupcake", "Breads", "Snack", "Beverage" };
            string[] ranFoodItemArray = { "Big Mac", "Aspestos Flavoured sausages", "Bacon Flavoured Icecream", "Mac and Cheese Filled Doughnuts", "frostly Flakes Flavoured Milk", "Plastic Cheese Burger", "Apple pie arsenic surpise", "A Warm Apple pie", "Cardboard Pizza", "Chocolate Cake", "Live Plus Energy Drink", "Oliver's Favorite Food" };

            string[] ranVendorNameArray = { "Kronos Incoporated", "Serious Foods Incorporated", "NovaGlobe Enterprises", "ElixirPrime Group", "Procrastination Solutions", "Unlimited Problems Ltd.", "Efficiency Experts Inc. (Don't Hold Your Breath)", "Painfully Slow Shipping Services", "Always Out of Stock Emporium", "Mediocre Solutions", "Underwhelming Results Agency", "Guaranteed Disappointment Corp.", "Metabolic sustenance" };

            string[] ranVehicleNameArray = { "Honda Civic", "Honda Del Sol", "Honda Accord", "Holden Crewman  S", "Holden Crewman SS", "Nissan Tiida Latio", "Mazda Verisa", "Ford Falcon FG XR6", "Ford Falcon BA XR8", "Nissan Cefiro", "Nissan Stagea", "Subaru WRX" };
            string[] ranVehicleTypeArray = { "StationWagon", "Sedan", "HatchBack", "Ute", "Shitbox" };

            string[] ranFurnitureNameArray = { "Leather couch 3000", "Thrustmaster 1000", "The Pull Out", "The waterbed", "regretabed" };
            string[] ranFurnitureTypeArray = { "Bed", "Couch", "Chair", "Occasional Furniture" };

            for (int i = 1; i < vCount; i++)
            {
                int r = RandVendor.Next(0, ranVendorNameArray.Length);

                modelBuilder.Entity<Vendor>().HasData(
                    new Vendor
                    {
                        VendorID = i,
                        Name = ranVendorNameArray[r],
                        Description = Faker.Lorem.Sentence(),
                        Location = Faker.Address.StreetAddress()
                    }
                );
            }

            for (int i = 1; i < ranFoodItemArray.Length; i++)
            {
                int r = RandVendor.Next(0, ranFoodItemArray.Length);
                int r1 = RandVendor.Next(0, ranFoodTypeArray.Length);

                modelBuilder.Entity<Food>().HasData(
                    new Food
                    {
                        FoodID = i,
                        FoodName = ranFoodItemArray[i],
                        FoodType = ranFoodTypeArray[r1],
                        FoodDescription = Faker.Lorem.Sentence(),
                        VendorID = RandVendor.Next(1, vCount)
                    }
                );
            }

            for (int i = 1; i < ranVehicleNameArray.Length; i++)
            {
                int r2 = RandVendor.Next(0, ranVehicleTypeArray.Length);
                modelBuilder.Entity<Vehicle>().HasData(
                    new Vehicle
                    {
                        vehicleID = i,
                        vehicleName = ranVehicleNameArray[i],
                        vehicleType = ranVehicleTypeArray[r2],
                        vehicleDescription = Faker.Lorem.Paragraph(),
                        VendorID = RandVendor.Next(1, vCount)
                    }
                );
            }

            for (int i = 1; i < ranFurnitureNameArray.Length; i++)
            {
                int r1 = RandVendor.Next(0, ranFurnitureNameArray.Length);
                int r2 = RandVendor.Next(0, ranFurnitureTypeArray.Length);
                modelBuilder.Entity<Furniture>().HasData(
                    new Furniture
                    {
                        furnitureID = i,
                        furnitureName = ranFurnitureNameArray[i],
                        furnitureType = ranFurnitureTypeArray[r2],
                        furnitureDescription = Faker.Lorem.Sentence(),
                        VendorID = RandVendor.Next(1, vCount)
                    }
                );
            }
        }

        public DbSet<Vendor> Vendor { get; set; } = default!;
        public DbSet<Food> Food { get; set; } = default!;
        public DbSet<Furniture> Furniture { get; set; } = default!;
        public DbSet<Vehicle> Vehicle { get; set; } = default!;
    }
}
