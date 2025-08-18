using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SniffHikes_Backend.Core.Entities
{
    public class Zone : BaseEntity
    {
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required IEnumerable<Image> Images { get; set; }
        public required string AddressId { get; set; }
        public ICollection<string>? CommentIds { get; set; }
        public string? OrganizerId { get; set; }
    }
}
