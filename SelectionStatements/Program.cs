// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
using System;

namespace SelectionStatements
{
    class Program
    {   //GenerateNum
        //Generates a random # between 1 and 1000
        // PARAMS: None
        // RETURNS: a random number between 1 and 1000
        public static    int GenerateNum()
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            return favNumber;
        }
        //GuessNum
        // Given a number, the function reads a guessed
        // input until that number is reached
        // PARAMS: The number
        // RETURNS: Total number of guesses
        public static int GuessNum(int num)
        {
            var userInput = -1;
            int count = 0;
            do
            {
                Console.WriteLine("Guess my favorite number (1-1000): ");
                userInput = int.Parse(Console.ReadLine());
                if (userInput < num)
                    Console.WriteLine("Too low.");
                else if (userInput > num)
                    Console.WriteLine("Too high");
                else
                    Console.WriteLine("Nevermind.");
                count++;
            } while (userInput != num);
            return count;
        
        }
        public static void Main(String[] args)
        {
            int num = GenerateNum();
            num = GuessNum(num);
            Console.WriteLine("This took {0} guess(es)", num);
        }
    }
}



