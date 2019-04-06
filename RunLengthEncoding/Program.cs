using System;
using System.Collections.Generic;
using System.Text;

namespace RunLengthEncoding
{
    class Program
    {
        static void Main(string[] args)
        {
            int userResponse;
            do
            {
                userResponse = Util.printUI();
                switch (userResponse)
                {
                    case 1:
                        Util.getNewUser();
                        break;
                    case 2:
                        Util.getUser();
                        break;
                    case 3:
                        Util.printUsers();
                        break;
                    default:
                        Console.WriteLine("I didn't understand what you wanted to do.");
                        break;
                }
            }
            while (userResponse != 3);

            System.Environment.Exit(0);
        }
    }

}
