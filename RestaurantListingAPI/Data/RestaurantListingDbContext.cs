using Microsoft.EntityFrameworkCore;

namespace RestaurantListingAPI.Data
{
    public class RestaurantListingDbContext: DbContext
    {
        public RestaurantListingDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<City>().HasData(
                new City
                {
                    Id = 1,
                    Name = "Orasje",
                    Country = "Bosnia and Herzegowina"
                },
                new City
                {
                    Id = 2,
                    Name = "Osijek",
                    Country = "Croatia"
                },
                 new City
                 {
                     Id = 3,
                     Name = "Zagreb",
                     Country = "Croatia"
                 }
           );
            modelBuilder.Entity<Restaurant>().HasData(
                new Restaurant
                {
                    Id = 1,
                    Name = "Baca",
                    Address = "4. ulica",
                    Rating = 4.4,
                    CityId = 1,
                },
                new Restaurant
                {
                    Id = 2,
                    Name = "Hamburgila",
                    Address = "75. ulica",
                    Rating = 4.5,
                    CityId = 2,
                },
                new Restaurant
                {
                    Id = 3,
                    Name = "Pivana Zuja",
                    Address = "Ilica 45",
                    Rating = 4.9,
                    CityId = 3,
                }
          );
        }
    }
}
