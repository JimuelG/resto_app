using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class RestoController : BaseApiController
    {
        private readonly IRestoRepository _repo;
        public RestoController(IRestoRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IReadOnlyList<Menu>> GetMenus()
        {
            return await _repo.GetMenusAsync();
        }

        [HttpGet("menu/{id}")]
        public async Task<Menu> GetMenuId(int id)
        {
            return await _repo.GetMenuByIdAsync(id);
        }

        [HttpGet]
        public async Task<IReadOnlyList<Order>> GetOrders()
        {
            return await _repo.GetOrdersAsync();
        }

        [HttpGet]
        public async Task<IReadOnlyList<RawMaterial>> GetRawMaterials()
        {
            return await _repo.GetRawMaterialsAsync();
        }

        [HttpGet]
        public async Task<IReadOnlyList<Recipe>> GetRecipes()
        {
            return await _repo.GetRecipesAsync();
        }
    }
}