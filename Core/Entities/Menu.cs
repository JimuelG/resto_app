namespace Core.Entities
{
    public class Menu : BaseEntity
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public decimal Price { get; set; }
        public required string PictureUrl { get; set; }
        public ICollection<Recipe> Recipes { get; set; }

    }
}