using System;

namespace ArraySumTo10
{
    class Program
    {
        //•	Find pairs in an integer array whose sum is equal to 10 (bonus: do it in linear time)
        static void Main(string[] args)
        {
            int[] input = { 4, 5, 3, 6, 5, 4, 6, 7, 4 };
            PairSumTo10(input);
            Console.ReadLine();
        }

        static void PairSumTo10(int[] input)
        {
            int j = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if(i+j == 10)
                {
                    Console.WriteLine($"{i} and {j} sum to 10.");
                }
            }
       
        }
    }
}
