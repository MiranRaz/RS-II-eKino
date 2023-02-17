﻿using eKino.Model;
using eKino.Model.Requests;
using eKino.Model.SearchObjects;
using eKino.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eKino.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class GenreController : BaseCRUDController<Model.Genre, GenreSearchObject, GenreUpsertRequest, GenreUpsertRequest>
    {
        public GenreController(iGenreService service)
            : base(service)
        {
        }
    }
}
