using eKino.Model;
using eKino.Model.Requests;
using eKino.Model.SearchObjects;
using eKino.Services.Database;
using eKino.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace eKino.Controllers
{
    public class MoviesController : BaseCRUDController<Model.Movies, MovieSearchObject, MoviesUpsertRequest, MoviesUpsertRequest>
    {
        public MoviesController(iMoviesService service)
            :base(service)
        {
        }
    }  
}