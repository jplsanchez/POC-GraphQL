using API.Entities;

namespace API.Contracts
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAll();
    }
}
