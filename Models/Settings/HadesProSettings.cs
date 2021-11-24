using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HadesPro.Models.Settings
{
    public class HadesProSettings
    {
        public string TmDbApiKey { get; set; }
        public string DefaultBackdropSize { get; set; }
        public string DefaultPosterSize { get; set; }
        public string DefaultYouTubeKey { get; set; }
        public string DefaultCastImage { get; set; }
        public DefaultCollection DefaultCollection { get; set; }
        public DefaultCredentials DefaultCredentials { get; set; }
    }

    public class DefaultCollection
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class DefaultCredentials
    {
        public string Role { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
