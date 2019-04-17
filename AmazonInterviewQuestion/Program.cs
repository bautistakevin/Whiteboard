using System;

namespace AmazonInterviewQuestion
{
    class Program
    {
        /* given a string, find the longest palindromic contiguous substring. If there are more than one with the maximum length, return any one.
         * for example, the longest palindromic substring of "aabcdcb" is "bcdcb". The longest palindromic substring of "bananas" is "anana".
         */
        static void Main(string[] args)
        {
            string input = "aabcdcb";
            string output = LongestContiguousPalindrome(input);
            Console.WriteLine($"The longest contiguous palindrome is '{output}'");
        }


        static string LongestContiguousPalindrome(string input)
        {
            string output = "";
            
            for (int i = 0; i < input.Length; i++)
            {
                int j = 1;
                while(((i - j) >= 0) && ((i + j) < input.Length) && (input[i - j] == input[i + j]))
                {
                    j++;
                }
                if(output.Length < (2 * j - 1))
                {
                    output = "";
                    for (int k = (i - j + 1); k < i + j; ++k)
                    {
                        output += input[k];
                    }
                }
                
            }
            return output;
        }
    }
}