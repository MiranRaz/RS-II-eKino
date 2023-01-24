using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKino.Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Database.User, Model.User>();
            CreateMap<Database.Movie, Model.Movies>();
            CreateMap<Database.Director, Model.Director>();
        }
    }
}
