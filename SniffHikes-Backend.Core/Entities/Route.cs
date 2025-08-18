using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SniffHikes_Backend.Core.Entities
{
    public class Route : BaseEntity
    {
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required string AddressId { get; set; }
        public required ICollection<string> ImageIds { get; set; }
        public DateTime DateCreated { get; set; }
        public ICollection<string>? CommentIds { get; set; }
        public required string UserId { get; set; }
    }
}
