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

            Console.Write("Array Output: ");
            for (int i = 0; i < userCreatedArray.Length; i++)
            {
                // ouput array to console
                Console.Write($"{userCreatedArray[i]} ");
            }
            Console.WriteLine();
            Console.Write("Enter a number between 1-10: ");
            int userScore = int.Parse(Console.ReadLine());

            return ArrayMaxResult(userCreatedArray, userScore);
        }

        // Challenge 2

        public static bool LeapYearCalc(int inputYear)
        {
            if (inputYear % 4 == 0 && inputYear % 100 != 0)            
                return true;            
            if (inputYear % 400 == 0)
                return true;
            else
                return false;
        }

        public static string problem2Caller()
        {
            Console.Write("Enter a year: ");
            int outputYear = int.Parse(Console.ReadLine());

            if (LeapYearCalc(outputYear))
                return $"{outputYear} is a leap year";
            else
                return $"{outputYear} is not a leap year";
        }

        // Challenge 3
        public static string PerfectSequence(int[] inputArray)
        {
            int sum = 0;
            int product = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] < 0)
                    return "No";
                else if(i == 0)
                {
                    sum = inputArray[i];
                    product = inputArray[i];
                }
                else
                {
                    sum += inputArray[i];
                    product *= inputArray[i];
                }

            }
            if (sum == product)
                return "Yes";
            else
                return "No";
        }

        public static void problem3Caller()
        {
            int[] numbers0 = { 2, 2 };
            int[] numbers1 = { 1, 3, 2 };
            int[] numbers2 = { 0, 0, 0, 0 };
            int[] numbers3 = { 4, 5, 6 };
            int[] numbers4 = { 0, 2, -2 };
            
            Console.WriteLine($"Problem 3 output: {PerfectSequence(numbers0)}.");
            Console.WriteLine($"Problem 3 output: {PerfectSequence(numbers1)}.");
            Console.WriteLine($"Problem 3 output: {PerfectSequence(numbers2)}.");
            Console.WriteLine($"Problem 3 output: {PerfectSequence(numbers3)}.");
            Console.WriteLine($"Problem 3 output: {PerfectSequence(numbers4)}.");
        }

        static void Main(string[] args)
        {
            //Console.WriteLine($"Problem 1 output: {problem1Caller()}.");
            //Console.WriteLine($"Problem 2 output: {problem2Caller()}.");
            problem3Caller();

            Console.ReadLine();
        }
    }
}
