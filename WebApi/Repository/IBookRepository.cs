using WebApi.Entities;

namespace WebApi.Repository
{
    public interface IBookRepository
    {
        Task AddAsync(Book book);

        Task<List<Book>> GetAsync();
    }
}