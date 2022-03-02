using rest_api.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace rest_api.Persistence.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> ListAsync();

        Task AddAsync(Category category);

        Task<Category> FindByIdAsync(int id);

        void Update(Category category);

        void Remove(Category category);

    }
}