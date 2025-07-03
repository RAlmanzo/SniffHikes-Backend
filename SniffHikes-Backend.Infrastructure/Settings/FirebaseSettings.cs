using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SniffHikes_Backend.Infrastructure.Settings
{
    public class FirebaseSettings
    {
        public required string DatabaseUrl { get; set; }
        public required string StorageUrl { get; set; }
    }
}
