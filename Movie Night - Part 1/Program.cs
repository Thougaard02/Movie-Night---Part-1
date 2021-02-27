using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Night___Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = MovieMananger.GetMovie();
            List<Actor> actors = MovieMananger.GetActor();
            List<Movie> movieSearch = MovieMananger.GetMovieSearch("Black Panther");
            List<Actor> ActorSearch = MovieMananger.GetActorSearch("Rasmus");
            List<Movie> movieGenre = MovieMananger.GetMovieGenre("Drama");

            Console.WriteLine("Movies");
            foreach (Movie movie in movies)
            {
                Console.WriteLine(movie.Title);
            }

            Console.WriteLine("\nActors");

            foreach (Actor actor in actors)
            {
                Console.WriteLine($"{actor.FirstName} {actor.LastName}");
            }

            Console.WriteLine("\nSearched movie");

            foreach (Movie movie in movieSearch)
            {
                Console.WriteLine(movie.Title);
            }

            Console.WriteLine("\nSearched Actor");

            foreach (Actor actor in ActorSearch)
            {
                Console.WriteLine(actor.FirstName);
            }

            Console.WriteLine("\nSearched Movie Genre");

            foreach (Movie movie in movieGenre)
            {
                Console.WriteLine(movie.Genre);
            }
            Console.ReadKey();
        }
    }
}
