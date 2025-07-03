using Firebase.Auth;
using Firebase.Auth.Providers;
using Firebase.Database;
using Firebase.Storage;
using Microsoft.Extensions.Options;
using Microsoft.VisualBasic;
using SniffHikes_Backend.Infrastructure.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SniffHikes_Backend.Infrastructure.Data
{
    public class FirebaseDbContext
    {
        public FirebaseClient Client { get; }
        public FirebaseStorage Storage { get; }

        public FirebaseDbContext(IOptions<FirebaseSettings> settings)
        {
            Client = new FirebaseClient(settings.Value.DatabaseUrl);
            Storage = new FirebaseStorage(settings.Value.StorageUrl);
        }
    }
}
