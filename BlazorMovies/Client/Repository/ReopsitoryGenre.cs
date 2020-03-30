using BlazorMovies.Client.Helpers;
using BlazorMovies.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Repository
{
    public class ReopsitoryGenre: IReopsitoryGenre
    {
        private string url = "api/genres";
        private readonly IHttpService _httpservice;
        public ReopsitoryGenre(IHttpService httpservice)
        {
            _httpservice = httpservice;
        }
        public async Task CreateGenre(Genre genre)
        {
            var reponse = await _httpservice.Post<Genre>(url, genre);
            if (!reponse.Success)
            {
                throw new ApplicationException(await reponse.GetBody());
            }
        }
        
    }
}
