using System;
using System.Collections.Generic;

namespace GoogleInterviewQuestion3
{
    /*given a list of integers S and a target number k, write a function that returns a subset of S that adds up
     * to k. if such a subset cannot be made, then return null.
     * 
     * integers can appear more than once in the list. You may assume all numbers in the list are positive.
     * 
     * for example, given S = [12,1,61,5,9,2] and k = 24, return [12,9,2,1] since it sums up to 24 */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<int> list = new List<int>();
            list.Add(12);
            list.Add(1);
            list.Add(61);
            list.Add(5);
            list.Add(9);
            list.Add(2);
            int K = 24;
            List<int> answer = new List<int>();
            answer = (SubsetSum(list, K));
            
            foreach(int i in answer)
            {
                Console.Write($"{i}, ");
            }


        }

        private static List<int> SubsetSum(List<int> input, int K)
        {
            List<int> output = new List<int>();
            int runningTotal = 0;
            for (int i = 0; i < input.Count; i++)
            {
                if( input[i] < K)
                {
                    output.Add(input[i]);
                    runningTotal += input[i];
                }
            }
            for (int j = 0;  j < output.Count;  j++)
            {
                if(K == (runningTotal-output[j]))
                {
                    output.Remove(output[j]);
                }
            }
            return output;
        }
    }
}
