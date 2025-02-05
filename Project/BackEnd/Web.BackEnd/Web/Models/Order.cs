namespace BackEnd.Models
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime TimeOrder { get; set; } = DateTime.Now;

        public decimal Price { get; set; }

        public Status status { get; set; }

        public enum Status
        {
            available,
            preparation,
            completed
        }

        public int UserID { get; set; }

        public User User { get; set; } = new User();

        public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
