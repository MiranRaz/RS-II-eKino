using Microsoft.AspNetCore.Mvc;
using eKino.Model;
using eKino.Services.Interfaces;
using eKino.Model.SearchObjects;
using Microsoft.AspNetCore.Authorization;
using eKino.Model.Requests;

namespace eKino.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : BaseCRUDController<Model.User, UserSearchObject, UserInsertRequest, UserUpdateRequest>
    {
        public UserController(iUserService service)
            : base(service)
        {
        }

        [Authorize(Roles = "Administrator")]
        public override User Insert([FromBody] UserInsertRequest insert)
        {
            return base.Insert(insert);
        }

        [Authorize(Roles = "Administrator")]
        public override User Update(int id, [FromBody] UserUpdateRequest update)
        {
            return base.Update(id, update);
        }

    }
}
