using Microsoft.AspNetCore.Mvc.Rendering;
using MovieLibrary.Models;
using System.Collections.Generic;

namespace MovieLibrary.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie> movies;
        public SelectList genres;
        public string movieGenre { get; set; }
    }
}
