using System;

namespace FridayNightRandomReturn
{
    class Program
    {
        static void Main(string[] args)
       { 

        string randomFood, randomDrink, randomMovie;
        string[] foods = { "chiken wings", "pizza", "sushi", "poopcorn", "salat" };
        string[] drink = { "apple juice", "rumm", "gin", "õlu", "siider" };
        string[] Movie = { "Speed", "Macqeen", "Üksinda kodus", "Titanic", "NFS" };

        randomFood =  PickRandomElementFromArray(foods);
        randomDrink = PickRandomElementFromArray(drink);
        randomMovie = PickRandomElementFromArray(Movie);

        Console.WriteLine($"Tonight you will have some {randomFood}, whit {randomDrink} and watch {randomMovie}");
        }
    private static int GenerateRandomIndex(string[] someArray)

       {
        Random rnd = new Random();
        int randomIndex = rnd.Next(0, someArray.Length);
        return randomIndex;
        }

    private static string PickRandomElementFromArray(string[] someArray)
        {
        string randomElement = someArray[GenerateRandomIndex(someArray)];
        return randomElement;

        }
    }
        
    
}
