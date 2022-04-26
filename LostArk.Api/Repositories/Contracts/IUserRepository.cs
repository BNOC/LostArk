using LostArk.Api.Entities;

namespace LostArk.Api.Repositories.Contracts
{
    public interface IUserRepository
    {
        Task<User> GetUser(int id);
    }
}
