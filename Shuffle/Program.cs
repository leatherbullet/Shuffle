using System;

namespace Shuffle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9,}; 

            for (int i = 0; i < numbers.Length; i++)
                Console.WriteLine(numbers[i] + " ");

            ShuffleArray(numbers);
        }

        static void ShuffleArray(int[] numbers)
        {
            int number = numbers.Length;

            Random random = new Random();

            for (int i = 0; i < number; i++)
                SwapArray(ref numbers, i, i + random.Next(number - i));

            for (int i = 0; i < number; i++)
                Console.Write(numbers[i] + " ");
        }

        static void SwapArray(ref int[] numbers, int index, int randomIndex) 
        { 
            int temp = numbers[index];
            numbers[index] = numbers[randomIndex];
            numbers[randomIndex] = temp;
        }
    }
}
