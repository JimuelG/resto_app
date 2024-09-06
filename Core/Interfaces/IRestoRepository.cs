using Core.Entities;

namespace Core.Interfaces
{
    public interface IRestoRepository
    {
        Task<Menu> GetMenuByIdAsync(int id);
        Task<IReadOnlyList<Menu>> GetMenusAsync();
        Task<IReadOnlyList<Order>> GetOrdersAsync();
        Task<IReadOnlyList<RawMaterial>> GetRawMaterialsAsync();
        Task<IReadOnlyList<Recipe>> GetRecipesAsync();

    }
}