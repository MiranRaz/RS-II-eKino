using eKino.Model;
using eKino.Services.Database;
using eKino.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace eKino.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BaseController<T, TSearch> : ControllerBase where T : class where TSearch : class
    {
        public iService<T, TSearch> Service { get; set; }
        public BaseController(iService<T, TSearch> service)
        {
            Service = service;
        }

        [HttpGet]
        public IEnumerable<T> Get([FromQuery]TSearch search=null)
        {
            return Service.Get();
        }

        [HttpGet("{id}")]
        public T GetByID(int id)
        {
            return Service.GetByID(id);
        }
    }
}