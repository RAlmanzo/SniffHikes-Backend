using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SniffHikes_Backend.Core.Entities
{
    public class Image : BaseEntity
    {
        public required string FileName { get; set; }
        public string? RouteId { get; set; }
        public string? EventId { get; set; }
        public string? ZoneId { get; set; }
        public required string UserId { get; set; }
        public string? DogId { get; set; }
    }
}
