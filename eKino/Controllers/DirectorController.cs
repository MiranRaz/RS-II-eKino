using eKino.Model;
using eKino.Model.SearchObjects;
using eKino.Services.Database;
using eKino.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace eKino.Controllers
{
   
    public class DirectorController : BaseController<Model.Director, DirectorSearchObject>
    { 
        public DirectorController(iDirectorService service)
            :base(service)
        {
        }
    }  
}