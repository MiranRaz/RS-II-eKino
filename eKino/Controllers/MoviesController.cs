using eKino.Services;
using Microsoft.AspNetCore.Mvc;

namespace eKino.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly iMoviesService _moviesService;

        public MoviesController(iMoviesService moviesService)
        {
            _moviesService = moviesService;
        }

        [HttpGet]
        public IEnumerable<Movies> Get()
        {  
            return _moviesService.Get();
        }

        [HttpGet("{id}")] 
        public Movies GetByID(int id)
        {
            return _moviesService.GetByID(id);
        }
    }  
}