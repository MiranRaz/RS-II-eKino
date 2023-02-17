using System;
using System.Collections.Generic;
using System.Text;

namespace eKino.Model.SearchObjects
{
    public class MovieSearchObject : BaseSearchObject
    {
        public string Title { get; set; }
        public int? Page { get; set; }
        public int? PageSize { get; set; }
    }
}
