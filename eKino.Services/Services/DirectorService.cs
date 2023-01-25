using AutoMapper;
using eKino.Model;
using eKino.Model.SearchObjects;
using eKino.Services.Database;
using eKino.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKino.Services.Services
{
    public class DirectorService : BaseService<Model.Director,Database.Director, DirectorSearchObject>,  iDirectorService
    {
        public DirectorService(eKinoContext context, IMapper mapper)
            : base(context,mapper)
        {
        }

        public override IQueryable<Database.Director> AddFilter(IQueryable<Database.Director> query, DirectorSearchObject? search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (!string.IsNullOrWhiteSpace(search?.Name))
            {
                filteredQuery = filteredQuery.Where(x => x.FullName == search.Name);
            }

            if(search?.DirectorID.HasValue == true)
            {
                filteredQuery = filteredQuery.Where(x => x.DirectorId == search.DirectorID);
            }

            return filteredQuery;
        }
    }
}
