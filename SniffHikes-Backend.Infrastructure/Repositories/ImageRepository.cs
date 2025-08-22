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
    public class ImageRepository : BaseRepository<Image>, IImageRepository
    {
        public ImageRepository(FirebaseDbContext context) : base(context)
        {
        }

        public Task<IEnumerable<Image>> GetImagesByDogIdAsync(string dogId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Image>> GetImagesByEventIdAsync(string eventId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Image>> GetImagesByRouteIdAsync(string routeId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Image>> GetImagesByUserIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Image>> GetImagesByZoneIdAsync(string zoneId)
        {
            throw new NotImplementedException();
        }
    }
}
