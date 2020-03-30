using BlazorMovies.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Repository
{
    public interface IReopsitoryGenre
    {
        Task CreateGenre(Genre genre);
    }
}
