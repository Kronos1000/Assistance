using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed data for Group table
            modelBuilder.Entity<Group>().HasData(
                new Group
                {
                    GroupId = 1,
                    Name = "admin"
                },
                new Group
                {
                    GroupId = 2,
                    Name = "user"
                }
            );

            // Seed data for AppUser table
            modelBuilder.Entity<AppUser>().HasData(
                new AppUser
                {
                    AppUserId = 1,
                    GroupId = 1,
                    Username = "admin",
                    Password = "admin"
                },
                new AppUser
                {
                    AppUserId = 2,
                    GroupId = 2,
                    Username = "user",
                    Password = "user"
                }
            );

            // Seed data for Restaurant table
            modelBuilder.Entity<Restaurant>().HasData(
                new Restaurant
                {
                    RestaurantId = 1,
                    Name = "McRonalds",
                    Rating = 2
                },
                new Restaurant
                {
                    RestaurantId = 2,
                    Name = "Burger Prince",
                    Rating = 4
                }
            );

            // Seed data for Food table
            modelBuilder.Entity<Food>().HasData(
                new Food
                {
                    FoodId = 1,
                    RestaurantId = 1,
                    Name = "The Tired Burger",
                    Description = "Eat The F*KING Burger",
                   Restaurant = null // Set the navigation property to null to avoid seeding circular references
                },
                new Food
                {
                    FoodId = 2,
                    RestaurantId = 2,
                    Name = "The Cheese Burger",
                    Description = "Come and get a face full of meat!!!",
                    Restaurant = null // Set the navigation property to null to avoid seeding circular references
                }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
