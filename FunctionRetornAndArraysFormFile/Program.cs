using System;

namespace FunctionRetornAndArraysFormFile
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomFood();
            DisplayRandomDrink();
            DisplayRandomMovie();
        }

        private static void DisplayRandomFood()
        {
            string[] foods = { "chiken wings", "pizza", "sushi", "poopcorn", "salat" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, foods.Length);

            string randomFood = foods[randomIndex];
            Console.WriteLine($"Computer picked: {randomFood}");
        }

        private static void DisplayRandomDrink()
            {
            string[] drinks = { "apple juice", "rumm", "gin", "õlu", "siider" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, drinks.Length);

            string randomDrink = drinks[randomIndex];
            Console.WriteLine($"Computer picked: {randomDrink}");

        }
        private static void DisplayRandomMovie()
        {
            string[] Movie = { "Speed", "Macqeen", "Üksinda kodus", "Titanic", "NFS" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, Movie.Length);

            string randomMovie = Movie[randomIndex];
            Console.WriteLine($"Computer picked: {randomMovie}");

        }
    }
}
