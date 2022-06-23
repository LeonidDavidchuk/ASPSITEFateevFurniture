namespace LenchikSite.Data
{
    public class Basket
    {
        public int Id { get; set; }
        public string Image { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Price { get; set; } = null!;
        public int FurnitureID { get; set; }
        public int UserID { get; set; }
    }
}
