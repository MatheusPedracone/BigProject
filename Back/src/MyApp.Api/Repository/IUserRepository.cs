using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MyApp.Api.Identity;

namespace MyApp.Api.Repository
{
    public interface IUserRepository : IGeralRepository
    {
        Task<IEnumerable<User>> GetAllUserAsync();
        Task<User> GetUserByIdAsync(Guid id);
        Task<User> GetUserByUsernameAsync(string username);
    }
} 