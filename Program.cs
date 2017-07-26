using System;
using System.Threading.Tasks;

namespace Momento
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var movieDb = new MovieDB();
            var movie = new Movie()
            {
                Name = "The Big Labowski",
                Length = 120 * 60
            };

            movie.Play();


            Console.WriteLine("Press enter to continue");
            Console.ReadLine();

            movie.Stop();

            movieDb.AddMovie(movie.GetState());

			Console.WriteLine("Press enter to continue");

			Console.ReadLine();

            movie = new Movie();

            movie.SetState(movieDb.GetMovie("The Big Labowski"));

            movie.Play();

			Console.WriteLine("Press enter to continue");

			Console.ReadLine();
        }
    }
}
