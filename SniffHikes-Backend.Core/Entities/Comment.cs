using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SniffHikes_Backend.Core.Entities
{
    public class Comment : BaseEntity
    {
        public required string Content { get; set; }
        public DateTime DateCreated { get; set; }
        public required string UserId { get; set; }
        public string? RouteId { get; set; }
        public string? EventId { get; set; }
    }
}
