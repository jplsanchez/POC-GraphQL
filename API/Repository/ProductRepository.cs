using API.Context;
using API.Contracts;

namespace API.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly MainDbContext _context;

        public ProductRepository(MainDbContext context)
        {
            _context = context;
        }
    }
}
