using WebApi.Entities;
using WebApi.Repository;

namespace WebApi.GraphQL
{
    public class Query
    {
        //public Book GetBook() =>
        //new Book
        //{
        //    Id = Guid.NewGuid(),
        //    Title = "The Lord of the Rings",
        //    Author = new Author
        //    {
        //        Name = "J.R.R. Tolkien"
        //    }
        //};

        public Task<List<Book>> GetBooks([Service] IBookRepository repository) => repository.GetAsync();
        public Task<List<Author>> GetAuthors([Service] IAuthorRepository repository) => repository.GetAsync();
    }
}
