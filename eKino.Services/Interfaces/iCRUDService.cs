using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKino.Services.Interfaces
{
    public interface iCRUDService<T, TSearch, TInsert, TUpdate> : iService<T, TSearch> where T : class where TSearch : class where TInsert : class where TUpdate : class
    {
        T Insert(TInsert insert);

        T? Update(int id, TUpdate update);
    }
}
