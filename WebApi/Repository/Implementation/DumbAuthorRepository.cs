using WebApi.Entities;

namespace WebApi.Repository.Implementation
{
    public class DumbAuthorRepository : IAuthorRepository
    {
        List<Author> Authors = new List<Author>();

        public async Task<Author?> GetAsync(Guid authorId)
        {
            return await Task.FromResult(Authors.FirstOrDefault(a => a.Id == authorId));
        }

        public async Task<List<Author>> GetAsync()
        {
            return await Task.FromResult(Authors);
        }

        public async Task<Author?> GetByNameAsync(string authorName)
        {
            return await Task.FromResult(Authors.FirstOrDefault(a => a.Name == authorName));
        }

        public Task AddAsync(Author author)
        {
            Authors.Add(author);
            return Task.CompletedTask;
        }

    }
}
