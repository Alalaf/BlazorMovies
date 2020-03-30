using BlazorMovies.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Repository
{
    public interface IReopsitoryPerson
    {
        Task CreatePerson(Person person);
    }
}
