using HadesPro.Models.Database;
using HadesPro.Models.TMBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HadesPro.Services.Interfaces
{
    public interface IDataMappingService
    {
        Task<Movie> MapMovieDetailAsync(MovieDetail movie);
        ActorDetail MapActorDetail(ActorDetail actor);
    }
}
