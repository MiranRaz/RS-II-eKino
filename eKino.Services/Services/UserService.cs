using AutoMapper;
using eKino.Services.Database;
using eKino.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKino.Services.Services
{
    public class UserService : BaseService<Model.User, Database.User, object>, iUserService
    {

        public UserService(eKinoContext context, IMapper mapper)
        :base(context, mapper)
        {
        }

    }
}
