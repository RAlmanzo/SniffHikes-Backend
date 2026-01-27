using SniffHikes_Backend.Core.Entities;
using SniffHikes_Backend.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SniffHikes_Backend.Core.Services
{
    public class UserService : IUserService
    {
        public Task<bool> AddDogAsync(string userId, Dog dog)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreateUserAsync(User newUser)
        {
            throw new NotImplementedException();
        }

        public Task<string> DeleteUserAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetAllUsersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateUserAsync(User toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
