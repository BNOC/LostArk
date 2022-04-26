namespace LostArk.Api.Entities
{
    public class Character
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int UserId { get; set; }

        public ICollection<CharacterTask> CharacterTasks { get; set; }
    }
}
