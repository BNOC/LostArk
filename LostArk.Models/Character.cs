namespace LostArk.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CharacterTask> CharacterTasks { get; set; }
    }
}
