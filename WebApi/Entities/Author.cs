namespace WebApi.Entities
{
    public class Author
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Author(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
