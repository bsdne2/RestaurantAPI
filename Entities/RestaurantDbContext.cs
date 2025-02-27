﻿using Microsoft.EntityFrameworkCore;
namespace RestaurantAPI.Entities
{
    public class RestaurantDbContext: DbContext
    {
        private string _connectionString =
            "Server=(localdb)\\mssqllocaldb;Database=RestaurantDb;Trusted_Connection=True;" ;
        //Server=(localdb)\\mssqllocaldb;Database=RazorPagesMovieContext-bc;Trusted_Connection=True;MultipleActiveResultSets=true
        public DbSet<Restaurant> Restaurant { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Dish> Dishes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Restaurant>()
                .Property(r => r.Name).IsRequired()
                .HasMaxLength(25);
            modelBuilder.Entity<Dish>()
              .Property(d => d.Name)
              .IsRequired();
                
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
