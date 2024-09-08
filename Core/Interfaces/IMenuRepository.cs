using Core.Entities;

namespace Core.Interfaces
{
    public interface IMenuRepository
    {
        Task<Menu> GetMenuByIdAsync(int id);
        Task<IReadOnlyList<Menu>> GetMenusAsync();
        void AddMenu(Menu menu);
        void UpdateMenu(Menu menu);
        void Delete(Menu menu);
        bool MenuExists(int id);
        Task<bool> SaveChangesAsync();
    }
}