using SniffHikes_Backend.Core.Entities;
using SniffHikes_Backend.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SniffHikes_Backend.Core.Services
{
    public class EventService : IEventService
    {
        public Task<string> CreateEventAsync(Event newEvent)
        {
            throw new NotImplementedException();
        }

        public Task<string> DeleteEventAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Event>> GetAllEventsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Event>> GetAllEventsByUserId(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Event> GetEventByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Event>> GetRegisteredEventsByUserId(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Event>> SearchEventByCity(string cityName)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SignUpToEvent(string id, string userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateEventAsync(Event toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
