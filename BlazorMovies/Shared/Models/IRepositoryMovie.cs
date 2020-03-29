using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorMovies.Shared.Models
{
    public interface IRepositoryMovie
    {
         List<Movie> GetMovies();
    }
}
