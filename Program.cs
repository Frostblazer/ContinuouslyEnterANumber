using System;
using System.Collections.Generic;

namespace ContinuouslyEnterANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var userNumbers = new List<int>();
            var userInput = "";

            while(userInput != "Quit")
            {
                Console.Write("Enter a number: ");
                userInput = Console.ReadLine();
        
                if(userInput != "Quit")
                {
                    var userNumber = Int32.Parse(userInput);
                    userNumbers.Add(userNumber);
                }               
            }

            var uniques = new List<int>();
            foreach (var element in userNumbers)
            {
                if (!uniques.Contains(element))
                {
                    uniques.Add(element);
                }                
            }

            foreach (int element in uniques)
            {
                Console.WriteLine(element);
            }
        }
    }
}
