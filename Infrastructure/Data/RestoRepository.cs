using System.Security.Cryptography.X509Certificates;
using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class RestoRepository(RestoContext context) : IRestoRepository
    {
        public async Task<Menu> GetMenuByIdAsync(int id)
        {
            return await context.Menus.FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<IReadOnlyList<Menu>> GetMenusAsync()
        {
            return await context.Menus.ToListAsync();
        }

        public async Task<IReadOnlyList<Order>> GetOrdersAsync()
        {
            return await context.Orders.ToListAsync();
        }

        public async Task<IReadOnlyList<RawMaterial>> GetRawMaterialsAsync()
        {
            return await context.RawMaterials.ToListAsync();
        }

        public async Task<IReadOnlyList<Recipe>> GetRecipesAsync()
        {
            return await context.Recipes.ToListAsync();
        }

    }
}