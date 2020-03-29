using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorMovies.Shared.Models
{
    public class RepositoryMovie : IRepositoryMovie
    {
        public List<Movie> GetMovies()
        {
            return new List<Movie>()
            {
                       new Movie()
                       {
                        Title = "Spider-Man: Far From Home", ReleaseDate = new DateTime(2019, 7, 2),
                       Poster = "https://terrigen-cdn-dev.marvel.com/content/prod/1x/spider-manfarfromhome_lob_crd_04_0.jpg"
                       },
                       new Movie()
                       {
                           Title = "Moana", ReleaseDate = new DateTime(2016, 11, 23),
                           Poster = "https://terrigen-cdn-dev.marvel.com/content/prod/1x/spider-manfarfromhome_lob_crd_04_0.jpg" 
                       },
                       new Movie()
                       {
                        Title = "Bat-Man:Dark Night", ReleaseDate = new DateTime(2010, 7, 16),
                           Poster = "https://terrigen-cdn-dev.marvel.com/content/prod/1x/spider-manfarfromhome_lob_crd_04_0.jpg"
                       }


            };
        }
    }          
}
    

    
