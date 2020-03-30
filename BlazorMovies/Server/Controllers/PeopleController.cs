using BlazorMovies.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PeopleController: ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public PeopleController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Person person)
        {
            _db.Add(person);
            await _db.SaveChangesAsync();
            return person.Id;
        }
    }
}
