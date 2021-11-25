using HadesPro.Models.Database;
using HadesPro.Models.TMBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HadesPro.Models.ViewModels
{
    public class LandingPageVM
    {
        public List<Collection> CustomCollections { get; set; }
        public MovieSearch NowPlaying { get; set; }
        public MovieSearch Popular { get; set; }
        public MovieSearch TopRated { get; set; }
        public MovieSearch Upcoming { get; set; }
    }
}
