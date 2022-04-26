using LostArk.Models;
using LostArk.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace LostArk.Web.Models
{
    public class CharacterTasksBase : ComponentBase
    {
        [Inject]
        public ICharacterTaskService CharacterTaskService { get; set; }

        public int Id { get; set; }
        public string Name { get; set; }

        [Parameter]
        public List<Character> Characters { get; set; }


        public CharacterTasksBase()
        {
        }

        public void CompleteCharacterTask(CharacterTask characterTask)
        {
            CharacterTaskService.UpdateCharacterTask(characterTask);
        }

        public string GetCharacterTaskTypeName(IGrouping<int, CharacterTask> groupedTasks)
        {
            var name = string.Empty;
            var a = groupedTasks.FirstOrDefault(x => x.CharacterTaskTypeId == groupedTasks.Key).CharacterTaskTypeId;
            
            switch(a)
            {
                case 1:
                    name = "Chaos Dungeon";
                    break;
                case 2:
                    name = "Guardian Raid";
                    break;
                case 3:
                    name = "Una's Daily";
                    break;
                case 4:
                    name = "Event";
                    break;
                case 5:
                    name = "Rapport";
                    break;
                case 6:
                    name = "Guild";
                    break;
                case 7:
                    name = "Una's Weekly";
                    break;
                default:
                    break;

            }
            return name;
        }
    }
}

