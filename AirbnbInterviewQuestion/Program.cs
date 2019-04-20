using System;
using System.Collections.Generic;

namespace AirbnbInterviewQuestion
{
      
    /*  Given a list of integers, write a function that returns the largest sum of non-adjacent numbers. Numbers
     *  can be 0 or negative.
     *  For example, [2, 4, 6, 2, 5] should return 13, since we pick 2, 6, and 5. [5, 1, 1, 5] should return 10,
     *  since we pick 5 and 5.
     *  Follow-up: Can you do this in O(N) time and constant space? 
     */

    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = new List<int>();
            input.Add(2);
            input.Add(4);
            input.Add(6);
            input.Add(2);
            input.Add(5);
            int output = NonAdjacentNumber(input);

            Console.WriteLine($"The biggest sum is {output}");

        }

        static int NonAdjacentNumber(List<int> input)
        {
            int runningTotal = 0, biggestSum = 0;
            
            for (int i = 0; i < input.Count; ++i)
            {                
                runningTotal += input[i];

                for (int j = 2+i; j < input.Count; j+=2)
                {
                    runningTotal += input[j];
                    if(runningTotal > biggestSum)
                    {
                        biggestSum = runningTotal;
                    }
                }

                runningTotal = 0;
            }
            return biggestSum;
        }
    }
}
