using LostArk.Models.Enums;

namespace LostArk.Models
{
    public class CharacterTask
    {
        public int Id { get; set; }

        public int CharacterTaskTypeId { get; set; }

        public bool IsCompleted { get; set; }

        public CharacterTaskPeriod Period { get; set; }

        public CharacterTaskType CharacterTaskType { get; set; }
    }
}
