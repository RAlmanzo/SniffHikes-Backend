using SniffHikes_Backend.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SniffHikes_Backend.Core.Interfaces.Services
{
    public interface IUserService
    {
        Task<User> GetUserByIdAsync(string id);
        Task<List<User>> GetAllUsersAsync();
        Task<bool> CreateUserAsync(User newUser);
        Task<bool> UpdateUserAsync(User toUpdate);
        Task<string> DeleteUserAsync(string id);
        Task<bool> AddDogAsync(string userId, Dog dog);
    }
}
