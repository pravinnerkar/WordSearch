using System;
using System.Collections.Generic;

namespace WordSearchApp
{
    internal partial class Program
    {
        static void Main(string[] args)
        {

            var matrix = new List<string>
            {
                "chill",
                "coldc",
                "water",
                "hello",
                "windy"
            };

            var wordStream = new List<string> { "chill", "cold", "wind", "snow", "rain", "chill" };
            var wordFinder = new WordFinder(matrix);
            var foundWords = wordFinder.Find(wordStream);

            Console.WriteLine("Found words:");
            foreach (var word in foundWords)
            {
                
                Console.WriteLine(word);
                
            }
            Console.ReadLine();

        }




}
}
