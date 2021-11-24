using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HadesPro.Models.Settings
{
    public class AppSettings
    {
        public HadesProSettings HadesProSettings { get; set; }
        public TMDBSettings TMDBSettings { get; set; }
    }
}
