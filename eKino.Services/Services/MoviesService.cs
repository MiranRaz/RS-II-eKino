using AutoMapper;
using eKino.Model;
using eKino.Model.Requests;
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
    public class MoviesService : BaseCRUDService<Model.Movies, Database.Movie, MovieSearchObject, MoviesInsertRequest, MoviesUpdateRequest>, iMoviesService
    {
        public MoviesService(eKinoContext context, IMapper mapper)
            :base(context, mapper)
        {
        }

        public override IQueryable<Database.Movie> AddFilter(IQueryable<Database.Movie> query, MovieSearchObject? search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (!string.IsNullOrWhiteSpace(search?.Title))
            {
                filteredQuery = filteredQuery.Where(x => x.Title == search.Title);
            }

            if(search?.Page.HasValue == true)
            {
                filteredQuery = filteredQuery.Take(search.PageSize.Value).Skip(search.Page.Value);
            }

            return filteredQuery;
        }


        //public List<Model.Movies> GetMoviesByTitle(string title)
        //{
        //    var result = Context.Movies.Where(x => x.Title == title).ToList();
        //}
    }
}
