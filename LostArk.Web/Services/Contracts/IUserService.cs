using LostArk.Web.Models;

namespace LostArk.Web.Services.Contracts
{
    public interface IUserService
    {
        Task<UserBase> GetUser(int id);
    }
}
