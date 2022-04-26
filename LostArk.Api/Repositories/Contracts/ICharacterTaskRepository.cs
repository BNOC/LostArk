using LostArk.Api.Entities;

namespace LostArk.Api.Repositories.Contracts
{
    public interface ICharacterTaskRepository
    {
        Task<CharacterTask> GetCharacterTask(int id);

        Task UpdateCharacterTask(int id, CharacterTask entity);

        Task<IEnumerable<CharacterTaskType>> GetCharacterTaskTypes();

        Task<CharacterTaskType> GetCharacterTaskType(int id);

        Task<IEnumerable<CharacterTask>> GetCharacterTasksByType(int id);
    }
}
