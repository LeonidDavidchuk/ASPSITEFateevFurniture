namespace LenchikSite.Data
{
    public class Furniture
    {
        public int Id { get; set; }
        public string Image { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Price { get; set; } = null!;
        public Category Category { get; set; } = null!;
    }
}
