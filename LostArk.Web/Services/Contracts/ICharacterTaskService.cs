using LostArk.Models;

namespace LostArk.Web.Services.Contracts
{
    public interface ICharacterTaskService
    {
        Task UpdateCharacterTask(CharacterTask characterTask);
    }
}
