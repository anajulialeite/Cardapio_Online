namespace BackEnd.Models
{
    public class Item
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public string Image { get; set; } = string.Empty;

        public int CategoryID { get; set; }

        public Category category { get; set; } = new Category();

        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

        public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
