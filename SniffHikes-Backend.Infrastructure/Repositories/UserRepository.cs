using SniffHikes_Backend.Core.Entities;
using SniffHikes_Backend.Core.Interfaces.Repositories;
using SniffHikes_Backend.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SniffHikes_Backend.Infrastructure.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(FirebaseDbContext context) : base(context)
        {
        }
    }
}
