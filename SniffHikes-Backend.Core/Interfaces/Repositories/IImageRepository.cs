using SniffHikes_Backend.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SniffHikes_Backend.Core.Interfaces.Repositories
{
    public interface IImageRepository : IBaseRepository<Image>
    {
        Task<IEnumerable<Image>> GetImagesByEventIdAsync(string eventId);
        Task<IEnumerable<Image>> GetImagesByRouteIdAsync(string routeId);
        Task<IEnumerable<Image>> GetImagesByZoneIdAsync(string zoneId);
        Task<IEnumerable<Image>> GetImagesByUserIdAsync(string userId);
    }
}
