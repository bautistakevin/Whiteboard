using System;

namespace GoogleInterviewQuestion2
{//INCOMPLETE
    //The power set of a set is the set of all its
    //subsets. Write a function that, given a set, generates its power set
    //i.e, given {1,2,3}
    //return {{},{1},{2},{3},{1,2},{1,3},{2,3},{1,2,3}}
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 1, 2, 3 };
            int[] output = GetPowerSet(input);
            Console.WriteLine("the max set of {1,2,3} is {0}", output);
        }

        private static int[] GetPowerSet(int[] input)
        {
            throw new NotImplementedException();
        }
    }
}
