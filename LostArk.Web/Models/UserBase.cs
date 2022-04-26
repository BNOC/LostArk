using LostArk.Models;
using LostArk.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace LostArk.Web.Models
{
    public class UserBase : ComponentBase
    {
        [Inject]
        public IUserService UserService { get; set; }

        public int Id { get; set; }
        public string Name { get; set; }

        public List<Character> Characters { get; set; }

        public UserBase()
        {
            Characters = new List<Character>();
        }
        protected override async Task OnInitializedAsync()
        {
            var user = await UserService.GetUser(1);
            Id = user.Id;
            Name = user.Name;
            Characters = user.Characters;
        }
    }
}

