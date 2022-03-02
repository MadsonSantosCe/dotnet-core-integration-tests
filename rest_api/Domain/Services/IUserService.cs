using rest_api.Domain.Models;
using System;
using System.Threading.Tasks;

namespace rest_api.Domain.Services
{
    public interface IUserService
    {
        Task<User> FirstOrDefaultAsync(String login, String password);
    }
}
