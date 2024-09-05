namespace Core.Entities
{
    public class Recipe : BaseEntity
    {
        public int MenuId { get; set; }
        public Menu Menu { get; set; }
        public int MaterialId { get; set; }
        public RawMaterial Material { get; set; }
        public int Quantity { get; set; }
    }
}