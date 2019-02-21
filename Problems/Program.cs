using System;
using System.Collections.Generic;

namespace Problems
{
    public class Program
    {
        public static string Prefix(string input)
        {
            if(input==null)
                return null;
            string[] first=input.Split();
            List<string> output=new List<string>();
            for(int stop=0; stop<first.Length;stop++)
            {
                if(first[stop]==" " || first[stop]=="")
                {

                }

                else
                {
                    output.Add(first[stop]);
                }
            }
            return($"{input.Length},{output.Count}:{input}");
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
