using eKino.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKino.Services.Interfaces
{
    public interface iService<T, TSearch> where T : class where TSearch : class
    {
        IEnumerable<T> Get(TSearch? search = null);
        T GetByID(int id);
    }
}