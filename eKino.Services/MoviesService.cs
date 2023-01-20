using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKino.Services
{
    public class MoviesService : iMoviesService
    {
        public List<Movies> MoviesList = new List<Movies>() { new Movies() { ID = 1, Name = "Kume" }, new Movies() { ID = 2, Name = "Godfather" } };
        public IEnumerable<Movies> Get()
        {
            MoviesList.Add(new Movies() { ID = -1, Name = "Lamse" });
            return MoviesList;
        }
        public Movies GetByID(int id)
        {
            return MoviesList.FirstOrDefault(i=>i.ID == id);
        }

    }
}
