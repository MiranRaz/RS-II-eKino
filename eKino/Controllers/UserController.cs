using Microsoft.AspNetCore.Mvc;
using eKino.Model;
using eKino.Services.Interfaces;

namespace eKino.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly iUserService _service;

        public UserController(iUserService userService)
        {
            _service = userService;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _service.Get();
        }

        //[HttpGet("{id}")]
        //public Model.User GetByID(int id)
        //{
        //    return _service.GetByID(id);
        //}
    }
}
