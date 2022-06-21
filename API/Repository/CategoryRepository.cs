using API.Context;
using API.Contracts;
using API.Entities;

namespace API.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly MainDbContext _context;

        public CategoryRepository(MainDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> GetAll() => _context.Categories.ToList();
    }
}
