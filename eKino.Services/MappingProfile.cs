using AutoMapper;
using eKino.Model.Requests;
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
            CreateMap<Database.Auditorium, Model.Auditorium>();
            CreateMap<Database.Genre, Model.Genre>();

            CreateMap<MoviesUpsertRequest, Database.Movie>();
            CreateMap<DirectorUpsertRequest, Database.Director>();
            CreateMap<UserInsertRequest, Database.User>();
            CreateMap<UserUpdateRequest, Database.User>();
            CreateMap<AuditoriumUpsertRequest, Database.Auditorium>();
            CreateMap<GenreUpsertRequest, Database.Genre>();
        }
    }
}
