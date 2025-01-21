namespace BackEnd.Models
{
    public class OrderItem
    {
        public int OrderID { get; set; }

        public Order Order { get; set; } = new Order();

        public int ItemID { get; set; }

        public Item Item { get; set; } = new Item();

        public double FreightSubtotal { get; set; }

        public double Amount { get; set; }


    }
}
