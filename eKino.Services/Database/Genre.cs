using System;
using System.Collections.Generic;

namespace eKino.Services.Database
{
    public partial class Genre
    {
        public int GenreId { get; set; }
        public string Name { get; set; } = null!;
    }
}
