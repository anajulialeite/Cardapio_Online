namespace BackEnd.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public virtual ICollection<Item> Items { get; set; } = new List<Item>();
    }
}
