﻿using Firebase.Database.Query;
using SniffHikes_Backend.Core.Entities;
using SniffHikes_Backend.Core.Interfaces.Repositories;
using SniffHikes_Backend.Infrastructure.Data;

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

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var items = await _context.Client.Child(_collectionTarget).OnceAsync<T>();

            return items.Select(x => 
            {
                var entity = x.Object;
                entity.Id = x.Key;
                return entity;
            });
        }

        public async Task CreateAsync(T toCreate)
        {
            await _context.Client.Child(_collectionTarget).PostAsync(toCreate);
        }

        public async Task UpdateAsync(T toUpdate)
        {
            await _context.Client.Child(_collectionTarget).Child(toUpdate.Id).PutAsync(toUpdate);
        }

        public async Task DeleteAsync(string id)
        {
            await _context.Client.Child(id).DeleteAsync();
        }
    }
}
