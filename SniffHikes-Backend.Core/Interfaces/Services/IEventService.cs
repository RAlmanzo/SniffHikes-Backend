using SniffHikes_Backend.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SniffHikes_Backend.Core.Interfaces.Services
{
    public interface IEventService
    {
        Task<Event> GetEventByIdAsync(string id);
        Task<IEnumerable<Event>> GetAllEventsAsync();
        Task<IEnumerable<Event>> GetAllEventsByUserId(string id);
        Task<string> CreateEventAsync(Event newEvent);
        Task<bool> UpdateEventAsync(Event toUpdate);
        Task<string> DeleteEventAsync(string id);
        Task<List<Event>> SearchEventByCity(string cityName);
        Task<bool> SignUpToEvent(string id, string userId);
        Task<IEnumerable<Event>> GetRegisteredEventsByUserId(string userId);
    }
}
