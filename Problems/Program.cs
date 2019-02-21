using System;

namespace Problems
{
    public class Program
    {
        static string Prefix (string input)
        {
            string[] output=input.Split(" ");
            return($"{input.Length},{output.Length}:{input}");
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Write the word you want info about...");
            string input= Console.ReadLine();
            Console.WriteLine(Prefix(input));
            Console.ReadLine();
        }
    }
}
