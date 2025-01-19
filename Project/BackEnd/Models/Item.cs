namespace BackEnd.Models
{
    public class Item
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public string Image { get; set; } = string.Empty;

        public virtual Category? IdCategoryNavigation { get; set; }

        public virtual ICollection<Order> IdOrders { get; set; } = new List<Order>();
    }
}
