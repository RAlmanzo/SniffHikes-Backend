using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SniffHikes_Backend.Core.Entities
{
    public class Dog: BaseEntity
    {
        public required string Name { get; set; }
        public required string Race { get; set; }
        public required string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public required string Image { get; set; }
        public required string UserId { get; set; }
    }
}
