using eKino.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKino.Services.Interfaces
{
    public interface iMoviesService
    {
        IEnumerable<Movies> Get();
        Movies GetByID(int id);
    }
}

