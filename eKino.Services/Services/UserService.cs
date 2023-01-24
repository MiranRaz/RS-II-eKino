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
    public class UserService : iUserService
    {
        public eKinoContext Context { get; set; }
        public IMapper Mapper { get; set; }

        public UserService(eKinoContext context, IMapper mapper)
        {
            Context = context;
            Mapper = mapper;
        }

        public IEnumerable<Model.User> Get()
        {
            List<Model.User> list = new List<Model.User>();
            var result = Context.Users.ToList();

            return Mapper.Map<List<Model.User>>(result);
        }

        //public Model.User GetByID(int id)
        //{
        //    var result = Context.Users.Find(id);

        //    return Mapper.Map<List<Model.User>>(result);
        //}
    }
}
