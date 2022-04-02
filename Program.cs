using System;

namespace BubbleSort
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("How many digits would you like to sort?");
            int numberOfDigits = Convert.ToInt32(Console.ReadLine());

            var watch = System.Diagnostics.Stopwatch.StartNew();
            int[] NumberArray = GenerateArray(numberOfDigits);
            int tempNumber, counter = 0, passNumber = 0;

            do
            {
                counter = 0;
                for (int i = 0; i < NumberArray.Length - 1; i++)
                {
                    if (NumberArray[i] > NumberArray[i + 1])
                    {
                        tempNumber = NumberArray[i];
                        NumberArray[i] = NumberArray[i + 1];
                        NumberArray[i + 1] = tempNumber;
                    }
                    else
                    {
                        counter++;
                    }
                }
                passNumber++;
                foreach (int number in NumberArray)
                    Console.Write("{0} ", number);
                Console.WriteLine();

                if (counter == NumberArray.Length - 1)
                    break;
            } while (counter != NumberArray.Length);

            Console.WriteLine("There was {0} passes in total", passNumber);
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds}ms");

            watch.Stop();
        }

        private static int[] GenerateArray(int lengthOfArray)
        {
            int[] numberArray = new int[lengthOfArray];
            Random rnd = new Random();

            for (int i = 0; i < lengthOfArray; i++)
            {
                numberArray[i] = rnd.Next(1, 200);
            }

            return numberArray;
        }
    }
}