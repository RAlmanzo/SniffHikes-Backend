using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace SniffHikes_Backend.Core.Entities
{
    public class Event : BaseEntity
    {
        public required string Title { get; set; }
        public required string Description { get; set; }
        public decimal? Price { get; set; }
        public required string AddressId { get; set; }
        public required ICollection<string> ImageIds { get; set; }
        public DateTime DateEvent { get; set; }
        public DateTime DateCreated { get; set; }
        public ICollection<string>? CommentIds { get; set; }
        public required string OrganizerId { get; set; }
        public ICollection<string>? AttendingUserIds { get; set; }
    }
}
