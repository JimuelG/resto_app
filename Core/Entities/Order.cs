namespace Core.Entities
{
    public class Order : BaseEntity
    {
        public int MenuId { get; set; }
        public Menu? Menu { get; set; }
        public required int Quantity { get; set; }
        public DateTime OrderDate { get; set; }
    }
}