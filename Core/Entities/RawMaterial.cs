namespace Core.Entities
{
    public class RawMaterial : BaseEntity
    {
        public required string Name { get; set; }
        public required int Quantity { get; set; }
    }
}