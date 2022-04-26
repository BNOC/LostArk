using LostArk.Api.Data;
using LostArk.Api.Entities;
using LostArk.Api.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace LostArk.Api.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly LostArkDbContext db;

        public UserRepository(LostArkDbContext _db)
        {
            db = _db;
        }
        public async Task<User> GetUser(int id)
        {
            return await db.Users.Include(x => x.Characters)
                                 .ThenInclude(x => x.CharacterTasks)
                                 .ThenInclude(x => x.CharacterTaskType) 
                                 .FirstOrDefaultAsync(i => i.Id == id);
        }
    }
}
