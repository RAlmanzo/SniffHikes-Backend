using SniffHikes_Backend.Core.Entities;
using SniffHikes_Backend.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SniffHikes_Backend.Core.Services
{
    public class ZoneService : IZoneService
    {
        public Task<string> CreateZoneAsync(Zone newZone)
        {
            throw new NotImplementedException();
        }

        public Task<string> DeleteZoneAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Zone>> GetAllZonesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Zone> GetZoneByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Zone>> SearchZoneByCity(string cityName)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateZoneAsync(Zone toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
