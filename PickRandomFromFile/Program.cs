using System;
using System.IO;

namespace PickRandomFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomFood, randomDrink, randomMovie;
            randomFood = GetRandomFromFile("foods.txt");
            randomDrink = GetRandomFromFile("Drinks.txt");
            randomMovie = GetRandomFromFile("Movies.txt");
            Console.WriteLine($"Tonight you will have some {randomFood}, whit {randomDrink} and watch {randomMovie}");
   
        } 
            private static int GenerateRandomIndex(string[] someArray)

            {
                Random rnd = new Random();
                int randomIndex = rnd.Next(0, someArray.Length);
                return randomIndex;
            }

            private static string GetRandomFromFile(string fileName)
        {
            string filePath = $@"C:\Users\...\Samples\{fileName}";
            string[] dataFromFile = File.ReadAllLines(filePath);
            string randomElements = dataFromFile[GenerateRandomIndex(dataFromFile)];

            return randomElements;
        }

    }
}
