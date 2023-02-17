using eKino.Model;
using eKino.Model.Requests;
using eKino.Model.SearchObjects;
using eKino.Services.Database;
using eKino.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace eKino.Controllers
{
   
    public class DirectorController : BaseCRUDController<Model.Director, DirectorSearchObject, DirectorUpsertRequest, DirectorUpsertRequest>
    { 
        public DirectorController(iDirectorService service)
            :base(service)
        {
        }
    }  
}