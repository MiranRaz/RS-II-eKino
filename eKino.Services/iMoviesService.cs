using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKino.Services
{
    public interface iMoviesService
    {
        IEnumerable<Movies> Get();
        Movies GetByID(int id);
    }
}

