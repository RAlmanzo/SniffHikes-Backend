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
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly FirebaseDbContext _context;
        private readonly string _collectionTarget;
        public BaseRepository(FirebaseDbContext context)
        {
            _collectionTarget = typeof(T).Name + "s";
            _context = context;
        }

        public async Task<T> GetByIdAsync(string id)
        {
            return await _context.Client.Child(_collectionTarget).OnceSingleAsync<T>();
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task CreateAsync(T toCreate)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T toUpdate)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
}
