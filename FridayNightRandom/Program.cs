using System;

namespace FridayNightRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomFood();
            DisplayRandomDrinks();
            DisplayRandomMovie();
        }

        private static int GenerateRandomIndex(string[] someArray)
        
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            return randomIndex;
        }

          private static void DisplayRandomFood()
        {
            string[] foods = { "chiken wings", "pizza", "sushi", "poopcorn", "salat" };
          

            Console.WriteLine($"Computer picked: {foods[GenerateRandomIndex(foods)]}");
        }

        private static void DisplayRandomDrinks()
        {
            string[] drinks = { "apple juice", "rumm", "gin", "õlu", "siider" };
        
            Console.WriteLine($"Computer picked: {drinks[GenerateRandomIndex(drinks)]}");

        }
        private static void DisplayRandomMovie()
        {
            string[] Movie = { "Speed", "Macqeen", "Üksinda kodus", "Titanic", "NFS" };
       
            Console.WriteLine($"Computer picked: {Movie[GenerateRandomIndex(Movie)]}");

        }
    }
}
