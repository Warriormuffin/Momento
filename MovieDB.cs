using System;
using System.Collections.Generic;

namespace Momento
{
    public class MovieDB
    {
        private Dictionary<string, MovieState> storage;

        public MovieDB()
        {
            storage = new Dictionary<string, MovieState>();
        }

        public void AddMovie(MovieState movie)
        {
            if(storage.ContainsKey(movie.Name)){
                storage[movie.Name] = movie;
            }
            storage.Add(movie.Name, movie);
        }

        public MovieState GetMovie(string name)
        {
			if (storage.ContainsKey(name))
			{
                return storage[name];
			}
            else{
                return null;
            }

        }
    }
}
