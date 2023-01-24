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
    public class DirectorService : iDirectorService
    {
        public eKinoContext Context { get; set; }
        public IMapper Mapper { get; set; }

        public DirectorService(eKinoContext context, IMapper mapper)
        {
            Context = context;
            Mapper = mapper;
        }


        public IEnumerable<Model.Director> Get()
        {
            var result = Context.Directors.ToList();

            return Mapper.Map<List<Model.Director>>(result);
        }

        public Model.Director GetByID(int id)
        {
            var result = Context.Directors.Find(id);
            return Mapper.Map<Model.Director>(result);
        }

    }
}
