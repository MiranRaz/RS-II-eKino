using AutoMapper;
using eKino.Model;
using eKino.Services.Database;
using eKino.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKino.Services.Services
{
    public class MoviesService : iMoviesService
    {
        public eKinoContext Context { get; set; }
        public IMapper Mapper { get; set; }

        public MoviesService(eKinoContext context, IMapper mapper)
        {
            Context = context;
            Mapper = mapper;
        }


        public IEnumerable<Movies> Get()
        {
            var result = Context.Movies.ToList();

            return Mapper.Map<List<Movies>>(result);
        }

        public Movies GetByID(int id)
        {
            var result = Context.Movies.Find(id);
            return Mapper.Map<Movies>(result);
        }

    }
}
