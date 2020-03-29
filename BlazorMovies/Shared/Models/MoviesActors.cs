using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorMovies.Shared.Models
{
   public class MoviesActors
    {
        public int PersonId { get; set; }
        public int MovieId { get; set; }
        public Person Person { get; set; }
        public string Character { get; set; }
        public int Order { get; set; }
    }
}
