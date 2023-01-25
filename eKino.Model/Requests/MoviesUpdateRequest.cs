using System;
using System.Collections.Generic;
using System.Text;

namespace eKino.Model.Requests
{
    public class MoviesUpdateRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Year { get; set; }
        public string RunningTime { get; set; }
    }
}
