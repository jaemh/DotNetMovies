using System.Collections.Generic;
using System.Linq;


namespace Movies.Services //conteiner
{

    public static class MoviesDbContextEnxtations
    {
        public static void CreateSeedData
            (this MoviesDbContext context)
        {

            if (context.Movies.Any()) // check that Movies is blank
                return;

            var movies = new List<Movie>(){
                        new Movie(){

                            Name = "La la Land",
                            Year = 2017
                        },

                        new Movie(){

                            Name = "Thor",
                            Year = 2017
                        },

                        new Movie(){

                            Name = "Fargo",
                            Year = 2013

                        }
                };

            context.AddRange(movies);
            context.SaveChanges();
        }
    }
}
