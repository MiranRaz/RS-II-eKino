using System;
using System.Collections.Generic;
using System.Text;

namespace eKino.Model.SearchObjects
{
    public class DirectorSearchObject : BaseSearchObject
    {
        public int? DirectorID { get; set; }
        public string Name { get; set; }
    }
}
