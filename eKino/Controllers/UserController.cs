using Microsoft.AspNetCore.Mvc;
using eKino.Model;
using eKino.Services.Interfaces;

namespace eKino.Controllers
{
    public class UserController : BaseController<Model.User, object>
    {
        public UserController(iUserService service)
        :base(service)
        {
        }
    }
}
