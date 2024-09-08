using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class RestoController(
        IGenericRepository<Menu> menuRepo, 
        IGenericRepository<Order> orderRepo, 
        IGenericRepository<RawMaterial> rawMaterialRepo, 
        IGenericRepository<Recipe> recipeRepo
        ) : BaseApiController
    {
        [HttpGet("menu/{id}")]
        public async Task<Menu> GetMenu(int id)
        {
            return await menuRepo.GetByIdAsync(id);
        }

        [HttpGet("menu")]
        public async Task<IReadOnlyList<Menu>> GetMenus()
        {
            return await menuRepo.ListAllAsync();
        }

        [HttpGet("order")]
        public async Task<IReadOnlyList<Order>> GetOrders()
        {
            return await orderRepo.ListAllAsync();
        }

        [HttpGet("order/{id}")]
        public async Task<Order> GetOrder(int id)
        {
            return await orderRepo.GetByIdAsync(id);
        }

        [HttpGet("recipe")]
        public async Task<IReadOnlyList<Recipe>> GetRecipes()
        {
            return await recipeRepo.ListAllAsync();
        }

        [HttpGet("recipe/{id}")]
        public async Task<Recipe> GetRecipe(int id)
        {
            return await recipeRepo.GetByIdAsync(id);
        }

        [HttpGet("raw_materials")]
        public async Task<IReadOnlyList<RawMaterial>> GetRawMaterials()
        {
            return await rawMaterialRepo.ListAllAsync();
        }

        [HttpGet("raw_materials/{id}")]
        public async Task<RawMaterial> GetRawMaterial(int id)
        {
            return await rawMaterialRepo.GetByIdAsync(id);
        }
    }
}