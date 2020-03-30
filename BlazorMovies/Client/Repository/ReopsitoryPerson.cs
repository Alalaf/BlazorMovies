using BlazorMovies.Client.Helpers;
using BlazorMovies.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Repository
{
    public class ReopsitoryPerson: IReopsitoryPerson
    {
        private string url = "api/People";
        private readonly IHttpService _httpservice;
        public ReopsitoryPerson(IHttpService httpservice)
        {
            _httpservice = httpservice;
        }
        public async Task CreatePerson(Person person)
        {
            var reponse = await _httpservice.Post<Person>(url, person);
            if (!reponse.Success)
            {
                throw new ApplicationException(await reponse.GetBody());
            }
        }
    }
}
