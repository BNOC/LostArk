using LostArk.Models;
using LostArk.Web.Services.Contracts;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace LostArk.Web.Services
{
    public class CharacterTaskService : ICharacterTaskService
    {
        private readonly HttpClient client;

        public CharacterTaskService(HttpClient _client)
        {
            client = _client;
        }   

        public async Task UpdateCharacterTask(CharacterTask characterTask)
        {
            try
            {
                characterTask.IsCompleted = !characterTask.IsCompleted;
                var model = JsonSerializer.Serialize(characterTask);
                var requestContent = new StringContent(model, Encoding.UTF8, "application/json");

                var response = await client.PutAsync($"api/CharacterTask/{characterTask.Id}", requestContent);
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();
                var createdThing = JsonSerializer.Deserialize<CharacterTask>(content);
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                var a = message;
                throw;
            }
        }
    }
}
