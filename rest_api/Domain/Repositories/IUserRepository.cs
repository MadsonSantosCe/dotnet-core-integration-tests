using rest_api.Domain.Models;
using System;
using System.Threading.Tasks;

namespace rest_api.Domain.Repositories
{
    public interface IUserRepository
    {
        Task<User> FirstOrDefaultAsync(String login, String password);
    }
}
