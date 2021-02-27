using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Night___Part_1
{
    static class MovieMananger
    {
        public static List<Movie> GetMovie()
        {
            return DalManager.GetMovie();
        }
        public static List<Actor> GetActor()
        {
            return DalManager.GetActors();
        }
        public static List<Movie> GetMovieSearch(string search)
        {
            return DalManager.GetMovieSearch(search);
        }
        public static List<Actor> GetActorSearch(string search)
        {
            return DalManager.GetActorsSearch(search);
        }
        public static List<Movie> GetMovieGenre(string search)
        {
            return DalManager.GetMovieGenreSearch(search);
        }
    }
}
