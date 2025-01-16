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
    }
}
