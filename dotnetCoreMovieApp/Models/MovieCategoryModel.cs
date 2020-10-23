using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetCoreMovieApp.Models
{
    public class MovieCategoryModel
    {
        public Movie Movie { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Movie> Movies { get; set; }
    }
}
