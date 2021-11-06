using System;
using System.IO;

namespace ChuckNorris
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomchuck;
            randomchuck = GetRandomFromFile("chuck.txt");
            Console.WriteLine($"{randomchuck}");
        }
        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            return randomIndex;
        }
        private static string GetRandomFromFile(string fileName)
        {
            string filePath = $@"C:\Users\ahtov\Samples\{fileName}";
            string[] dataFromFile = File.ReadAllLines(filePath);
            string randomElements = dataFromFile[GenerateRandomIndex(dataFromFile)];

            return randomElements;
        }
    }
}
