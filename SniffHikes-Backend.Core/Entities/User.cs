using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SniffHikes_Backend.Core.Entities
{
    public class User : BaseEntity
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public required string Email { get; set; }
        public required string Gender { get; set; }
        public required string AddressId { get; set; }
        public ICollection<string>? CommentIds { get; set; }
        public ICollection<string>? DogIds { get; set; }
        public ICollection<string>? RouteIds { get; set; }
        public ICollection<string>? ZoneIds { get; set; }
        public ICollection<string>? OrganizedEventIds { get; set; }
        public ICollection<string>? AttendingEventIds { get; set; }
        public required string ImageId { get; set; }
    }
}
