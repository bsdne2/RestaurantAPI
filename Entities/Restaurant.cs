namespace RestaurantAPI.Entities
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descryption { get; set; }
        public string Category { get; set; }
        public bool HasDelivery { get; set; }
        public string ContacEmail { get; set; }
        public string ContacNumber { get; set; }
        public int AdressId { get; set; }
        public virtual Address Address { get; set; }
        public virtual List<Dish> Dishes { get; set; }
    }
}
