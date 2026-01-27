using SniffHikes_Backend.Core.Entities;
using SniffHikes_Backend.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SniffHikes_Backend.Core.Services
{
    public class RouteService : IRouteService
    {
        public Task<string> CreateRouteAsync(Route newRoute)
        {
            throw new NotImplementedException();
        }

        public Task<string> DeleteRouteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Route>> GetAllRoutesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Route>> GetAllRoutesByUserId(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Route> GetRouteByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Route>> SearchRouteByCity(string cityName)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateRouteAsync(Route toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
