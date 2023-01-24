using eKino.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKino.Services.Interfaces
{
    public interface iDirectorService
    {
        IEnumerable<Director> Get();
        Director GetByID(int id);
    }
}
