namespace WebApi.Entities
{
    public class Book
    {
        public Guid Id {get; set; }

        public string Title { get; set; }

        public Author Author { get; set; }

        public Book(Guid id, string title, Author author)
        {
            Id = id;
            Title = title;
            Author = author;
        }
    }
}
