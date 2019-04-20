using System;

namespace MicrosoftInterviewQuestion
{
    /*Given an integer x. The task is 
     * to find the square root of x. If x is not a perfect square, 
     * then return floor(√x).*/

    class Program
    {
        static void Main(string[] args)
        {
            int input = 5;
            int output = SquareRoot(input);
            Console.WriteLine($"the floor square root of {input} is {output}" );
            input = 6;
            output = SquareRoot(input);
            Console.WriteLine($"the floor square root of {input} is {output}");
            input = 10;
            output = SquareRoot(input);
            Console.WriteLine($"the floor square root of {input} is {output}");
        }
        static int SquareRoot(int x)
        {
            int square = 0;
            for (int i = 1; i < x; i++)
            {
                if( ((i*i) <= x) && (((i+1)*(i+1) >= x)))
                {
                    square = i;
                }
            }
            return square;
        }
    }
}
