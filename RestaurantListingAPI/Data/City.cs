namespace RestaurantListingAPI.Data
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public virtual IList<Restaurant> Restaurants { get; set; }
    }
}