using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HadesPro.Models.Database
{
    public class MovieCrew
    {
        public int Id { get; set; }
        public int MovieId { get; set; }

        public int CrewID { get; set; }
        public string Department { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public string ImageUrl { get; set; }

        public Movie Movie { get; set; }

    }
}
