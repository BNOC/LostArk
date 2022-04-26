using LostArk.Api.Data;
using LostArk.Api.Entities;
using LostArk.Api.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace LostArk.Api.Repositories
{
    public class CharacterTaskRepository : ICharacterTaskRepository
    {
        private readonly LostArkDbContext db;

        public CharacterTaskRepository(LostArkDbContext _db)
        {
            db = _db;
        }
        public async Task<CharacterTask> GetCharacterTask(int id)
        {
            return await db.CharacterTasks.FindAsync(id);
        }

        public async Task UpdateCharacterTask(int id, CharacterTask thing)
        {
            var model = await db.CharacterTasks.FindAsync(id);
            if (model != null)
            {
                model.IsCompleted = thing.IsCompleted;

                await db.SaveChangesAsync();
            }
        }


        // Type 
        public async Task<IEnumerable<CharacterTaskType>> GetCharacterTaskTypes()
        {
            return await this.db.CharacterTaskTypes.ToListAsync();
        }

        public async Task<CharacterTaskType> GetCharacterTaskType(int id)
        {
            return await db.CharacterTaskTypes.SingleOrDefaultAsync(c => c.Id == id);
        }

        public async Task<IEnumerable<CharacterTask>> GetCharacterTasksByType(int id)
        {
            var products = await this.db.CharacterTasks
                                     .Include(p => p.CharacterTaskType)
                                     .Where(p => p.CharacterTaskTypeId == id).ToListAsync();
            return products;
        }
    }
}
