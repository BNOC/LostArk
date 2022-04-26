using LostArk.Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace LostArk.Api.Entities
{
    public class CharacterTask
    {
        public int Id { get; set; }

        public int CharacterId { get; set; }

        public bool IsCompleted { get; set; }

        public CharacterTaskPeriod Period { get; set; }

        public int CharacterTaskTypeId { get; set; }

        [ForeignKey("CharacterTaskTypeId")]
        public virtual CharacterTaskType CharacterTaskType { get; set; }
    }
}
