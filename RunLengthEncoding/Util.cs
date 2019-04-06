using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace RunLengthEncoding
{
    public class Util
    {
        static Dictionary<String, byte[]> Users = new Dictionary<String, byte[]>();
        static SHA1 sHA1 = new SHA1CryptoServiceProvider();

        public static int printUI()
        {
            int userResponse;
            Console.WriteLine("---------------------------------------------------------------\n");
            Console.WriteLine("PASSWORD AUTHENTICATION SYSTEM \n");
            Console.WriteLine("Please select one option:");
            Console.WriteLine("1. Establish an account");
            Console.WriteLine("2. Authenticate a user");
            Console.WriteLine("3. Exit the system \n");
            Console.WriteLine("Enter Selection");
            Console.WriteLine("---------------------------------------------------------------\n");
            userResponse = int.Parse(Console.ReadLine());
            return userResponse;
        }

        public static void getUser()
        {
            SHA1 sHA1 = new SHA1CryptoServiceProvider();
            Console.WriteLine("Please enter your username and password:");
            Console.WriteLine("Username: ");
            string username = Console.ReadLine();
            Console.WriteLine("password: ");
            string password = Console.ReadLine();
            byte[] passwordBytes = Encoding.ASCII.GetBytes(password);
            byte[] encryptedPasswordBytes = sHA1.ComputeHash(passwordBytes);
            if (Users.ContainsKey(username) && Users[username].SequenceEqual(encryptedPasswordBytes))
            {
                Console.WriteLine("authenticated.");
            }
            else
            {
                Console.WriteLine("wrong username/password. please try again");
            }

        }

        public static void getNewUser()
        {
            Console.WriteLine("Please enter your username and password:");
            Console.WriteLine("Username: ");
            string username = Console.ReadLine();
            if (Users.ContainsKey(username))
            {
                Console.WriteLine("username is already taken. please try another: ");
                username = Console.ReadLine();
            }
            Console.WriteLine("password: ");
            string password = Console.ReadLine();
            byte[] passwordBytes = Encoding.ASCII.GetBytes(password);
            Users.Add(username, sHA1.ComputeHash(passwordBytes));
        }

        public static void printUsers()
        {
            foreach (KeyValuePair<String, byte[]> entry in Users)
            {
                Console.WriteLine("Key: " + entry.Key);
                Console.WriteLine("Value: " + Encoding.ASCII.GetString(entry.Value));
                Console.ReadLine();
            }
        }
    }

}
