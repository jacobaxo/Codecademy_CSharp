using System;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
            int minLength = 7;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string didgits = "012356789";
            string specialChars = "!@#$%^&*()_-+=~`[];:,.<>";

            Console.WriteLine("Please input a password: ");
            string password = Console.ReadLine();

            int score = 0;

            if (score <= 0)
            {
                score++;
            }
            if (Tools.Contains(password, lowercase))
            {
                score++;
            }
            if (Tools.Contains(password, uppercase))
            {
                score++;
            }
            if (Tools.Contains(password, didgits))
            {
                score++;
            }
            if (Tools.Contains(password, specialChars))
            {
                score++;
            }
            Console.WriteLine(score);
            switch (score)
            {
                case 1:
                    Console.WriteLine("Weak.");
                    break;
                case 2:
                    Console.WriteLine("Medium.");
                    break;
                case 3:
                    Console.WriteLine("Strong.");
                    break;
                case 4:
                    Console.WriteLine("Extremly strong!");
                    break;
                case 5:
                    Console.WriteLine("Extremely strong again!");
                    break;
                default:
                    Console.WriteLine("you aint do it right");
                    break;
            }
        }
    }
}
