using eKino.Services.Interfaces;
using eKino.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace eKino.Services.Services
{
    public class BaseService<T, TDb, TSearch> : iService<T, TSearch> where T : class where TDb : class where TSearch : class
    {
        public eKinoContext Context { get; set; }
        public IMapper Mapper { get; set; }

        public BaseService(eKinoContext context, IMapper mapper)
        {
            Context = context;
            Mapper = mapper;
        }

        public IEnumerable<T> Get(TSearch? search = null)
        {
            var entity = Context.Set<TDb>().AsQueryable();

            entity = AddFilter(entity, search);

            var list = entity.ToList();

            return Mapper.Map<IEnumerable<T>>(list);
        }

        public virtual IQueryable<TDb> AddFilter(IQueryable<TDb> query, TSearch? search = null)
        {
            return query;
        }
        public T GetByID(int id)
        {
            var set = Context.Set<TDb>();
            var entity = set.Find(id);

            return Mapper.Map<T>(entity);
        }
    }
}
