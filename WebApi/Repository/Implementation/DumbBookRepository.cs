using WebApi.Entities;

namespace WebApi.Repository.Implementation
{
    public class DumbBookRepository : IBookRepository
    {
        List<Book> Books = new List<Book>();

        public Task<List<Book>> GetAsync()
        {
            return Task.FromResult(Books);
        }

        public Task AddAsync(Book book)
        {
            Books.Add(book);
            return Task.CompletedTask;
        }
    }
}
