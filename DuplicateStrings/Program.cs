using System;

namespace DuplicateStrings
{
    //Remove all duplicate characters in a given string
    //input = "Microsoft"
    //output = "Micrsft"
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Microsoft";
            string result = DuplicateRemoval(input);
            Console.WriteLine($"input = {input}, output = {result}");

        }

        static string DuplicateRemoval(string input)
        {
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                int counter = 0;
                for (int j = 0; j < input.Length; j++)
                {
                   if(i==j)
                    {
                        j++;
                    }
                   else if(input[i]==input[j])
                    {
                        counter++;
                    }                  
                }
                if (counter == 0)
                {
                    output += input[i];
                }

            }
            return output;
        }
    }
}
