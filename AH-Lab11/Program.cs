using System;
using System.Collections.Generic;

namespace Lab11
{
    class Program
    {
        

        public static void Main(string[] args)
        {
            string movie = new List<Movie[]>

            {

                new Movie("RugRats", $"[Category.animated]");
                new Movie("LionKing", $"[Category.animated]");
                new Movie("The invisible man", $"[Category.horror]");
                new Movie("Fantacy island", $"[Category.horror]");
               new Movie("Little women", $"[Category.drama]");
                new Movie("Spotlight", $"[Category.drama]");
                new Movie("Joker", $"[Category.scifi]");
               new Movie("Avengers", $"[Category.scifi]");
                new Movie("venom", $"[Category.scifi]");
            };

        Console.WriteLine($"Welcome to the, {movie}, there are 10 movies in this list");

                do
                {
                   public category movieType;

                    bool valid;
                    
                    {do
                        Console.WriteLine($"What category are you interested in? \nPlease pick from: \n(1) {Category.animated}, \n(2) {Category.horror}, \n(3) {Category.drama}, \n(4) {Category.scifi}");
                        valid = Category.TryParse(Console.ReadLine(), out movieType);
                    } while (!valid);
                    Console.WriteLine($"\nHere are the {movieType} of movies we have");
                    foreach (var movie in MovieList)
                    {
                        if (movie.GetCategory() == movieType)
                            Console.WriteLine(movie.GetTitle());
                    }
                    Console.WriteLine("Would you like to continue? y/n");
                } while (Console.ReadLine() == "y");


            }
        }

        private static void List<T>()
        {
            throw new NotImplementedException();
        }
    }
}