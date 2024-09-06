using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class UserController(IUserRepository repo) : BaseApiController
    {
        [HttpGet]
        public async Task<IReadOnlyList<User>> GetUsers()
        {
            return await repo.GetUsersAsync();
        }
        
        [HttpGet("{id}")]
        public async Task<User> GetUser(int id)
        {
            return await repo.GetUserByIdAsync(id);
        }

        [HttpPost]
        public async Task<User> CreateUser(User user)
        {
            repo.AddUser(user);

            await repo.SaveChangesAsync();

            return user;
        }
    }
}