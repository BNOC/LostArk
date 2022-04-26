using LostArk.Web.Models;
using LostArk.Web.Services.Contracts;
using System.Net.Http.Json;

namespace LostArk.Web.Services
{
    public class UserService : IUserService
    {
        private readonly HttpClient client;

        public UserService(HttpClient _client)
        {
            client = _client;
        }

        public async Task<UserBase> GetUser(int id)
        {
            try
            {
                var response = await client.GetAsync($"api/User/{id}");
                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return default;
                    }

                    return await response.Content.ReadFromJsonAsync<UserBase>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception(message);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
