using eKino.Model;
using eKino.Services.Database;
using eKino.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace eKino.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DirectorController : ControllerBase
    {
        private readonly iDirectorService _Service;

        public DirectorController(iDirectorService service)
        {
            _Service = service;
        }

        [HttpGet]
        public IEnumerable<Model.Director> Get()
        {  
            return _Service.Get();
        }

        [HttpGet("{id}")] 
        public Model.Director GetByID(int id)
        {
            return _Service.GetByID(id);
        }
    }  
}