using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class MenuRepository(RestoContext context) : IMenuRepository
    {
        public void AddMenu(Menu menu)
        {
            context.Menus.Add(menu);
        }

        public void Delete(Menu menu)
        {
            context.Menus.Remove(menu);
        }

        public async Task<Menu> GetMenuByIdAsync(int id)
        {
            return await context.Menus.FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<IReadOnlyList<Menu>> GetMenusAsync()
        {
            return await context.Menus.ToListAsync();
        }

        public bool MenuExists(int id)
        {
            return context.Menus.Any(m => m.Id == id);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await context.SaveChangesAsync() > 0;
        }

        public void UpdateMenu(Menu menu)
        {
            context.Entry(menu).State = EntityState.Modified;
        }
    }
}