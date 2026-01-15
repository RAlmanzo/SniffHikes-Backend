using SniffHikes_Backend.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SniffHikes_Backend.Core.Interfaces.Services
{
    public interface IRouteService
    {
        Task<Route> GetRouteByIdAsync(string id);
        Task<IEnumerable<Route>> GetAllRoutesAsync();
        Task<IEnumerable<Route>> GetAllRoutesByUserId(string id);
        Task<string> CreateRouteAsync(Route newRoute);
        Task<bool> UpdateRouteAsync(Route toUpdate);
        Task<string> DeleteRouteAsync(string id);
        Task<List<Route>> SearchRouteByCity(string cityName);
    }
}
