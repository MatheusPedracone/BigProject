using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyApp.Api.Data;
using MyApp.Api.Identity;

namespace MyApp.Api.Repository.Implementations
{
    public class UserRepository : GeralRepository, IUserRepository
    {
        private readonly DataContext _context;
        public UserRepository(DataContext context) : base(context)
        {
            _context = context;
        }
        public async Task<IEnumerable<User>> GetAllUserAsync()
        {
            return await _context.Users.ToListAsync();
        }
        public async Task<User> GetUserByIdAsync(Guid id)
        {
            return await _context.Users.FindAsync(id);
        }
        public async Task<User> GetUserByUsernameAsync(string username)
        {
            return await _context.Users.AsNoTracking()
                     .FirstOrDefaultAsync(user => user.FirstName == username.ToLower());
        }
    }
}