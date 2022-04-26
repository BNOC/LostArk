namespace LostArk.Api.Entities
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Character> Characters { get; set; }

    }
}
