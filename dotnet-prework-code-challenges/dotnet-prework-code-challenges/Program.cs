using System;

namespace dotnet_prework_code_challenges
{
    class Program
    {
        // Challenge 1

        public static int ArrayMaxResult(int[] inputArray, int inputNumber)
        {
            int counter = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == inputNumber)
                    counter++;
            }

            int outputScore = counter * inputNumber;
            //Console.WriteLine(outputScore);
            return outputScore;
        }

        public static int problem1Caller()
        {
            int[] userCreatedArray = new int[5];

            for (int i = 0; i < 5; i++)
            {
                // Conditional for proper grammar
                if(i == 0)
                {
                    Console.Write("Enter a number between 1-10: ");
                    userCreatedArray[i] = int.Parse(Console.ReadLine());
                } 
                else
                {
                    Console.Write("Enter another number between 1-10: ");
                    userCreatedArray[i] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < userCreatedArray.Length; i++)
            {
                // ouput array to console
                Console.Write($"{userCreatedArray[i]} ");
            }

            Console.Write("Enter a number between 1-10: ");
            int userScore = int.Parse(Console.ReadLine());

            return ArrayMaxResult(userCreatedArray, userScore);
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"Problem 1 output: {problem1Caller()}.");
            Console.ReadLine();
        }
    }
}
