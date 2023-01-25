using AutoMapper;
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
    public class BaseCRUDService<T, TDb, TSearch, TInsert, TUpdate> 
        : BaseService<T, TDb, TSearch>, iCRUDService<T, TSearch, TInsert, TUpdate>
        where T : class where TDb : class where TSearch : class where TInsert : class where TUpdate : class
    {
        public BaseCRUDService(eKinoContext context, IMapper mapper):base(context,mapper) { }

        public T Insert (TInsert insert)
        {
            var set = Context.Set<TDb>();

            TDb entity = Mapper.Map<TDb>(insert);
            
            set.Add(entity);
            Context.SaveChanges();

            return Mapper.Map<T>(entity);
        }

        public T Update(int id, TUpdate update)
        {
            var set = Context.Set<TDb>();

            var entity = set.Find(id);

            if(entity != null)
            {
                Mapper.Map(update, entity);
            }
            else
            {
                return null;
            }
            Context.SaveChanges();

            return Mapper.Map<T>(entity);
        }

    }
}
