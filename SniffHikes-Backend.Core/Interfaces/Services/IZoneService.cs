using SniffHikes_Backend.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SniffHikes_Backend.Core.Interfaces.Services
{
    public interface IZoneService
    {
        Task<Zone> GetZoneByIdAsync(string id);
        Task<List<Zone>> GetAllZonesAsync();
        Task<string> CreateZoneAsync(Zone newZone);
        Task<bool> UpdateZoneAsync(Zone toUpdate);
        Task<string> DeleteZoneAsync(string id);
        Task<List<Zone>> SearchZoneByCity(string cityName);
    }
}
