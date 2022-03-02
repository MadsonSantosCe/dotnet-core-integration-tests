using rest_api.Domain.Models;
using rest_api.Domain.Repositories;
using rest_api.Domain.Services;
using System;
using System.Threading.Tasks;

namespace rest_api.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> FirstOrDefaultAsync(String login, String password)
        {
            return await _userRepository.FirstOrDefaultAsync(login, password);
        }
    }
}
