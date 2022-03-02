using Microsoft.EntityFrameworkCore;
using rest_api.Domain.Models;
using rest_api.Domain.Repositories;
using rest_api.Persistence.Contexts;
using System;
using System.Threading.Tasks;

namespace rest_api.Persistence.Repositories
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<User> FirstOrDefaultAsync(String login, String password)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.Login == login && x.Password == password);
        }

    }
}
