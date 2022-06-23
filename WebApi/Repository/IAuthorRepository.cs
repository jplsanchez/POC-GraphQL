using WebApi.Entities;

namespace WebApi.Repository
{
    public interface IAuthorRepository
    {
        Task AddAsync(Author author);

        Task<List<Author>> GetAsync();

        Task<Author?> GetAsync(Guid authorId);

        Task<Author?> GetByNameAsync(string authorName);
    }
}
