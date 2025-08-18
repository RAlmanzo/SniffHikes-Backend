using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SniffHikes_Backend.Core.Entities
{
    public class Image
    {
        public required string FileName { get; set; }
        public int? RouteId { get; set; }
        public int? EventId { get; set; }
    }
}
