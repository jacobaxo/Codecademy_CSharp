using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            Console.WriteLine("type a message to encrypt it.");
            string message = Console.ReadLine();
            char[] secretMessage = message.ToCharArray();

            char[] encryptedMessage = new char[secretMessage.Length];

            int i;
            for (i = 0; i < secretMessage.Length; i++)
            {
                char secretItem = secretMessage[i];
                int index = Array.IndexOf(alphabet, secretItem);
                int letterPosition = (index += 3) % 26;
                char encryptedCharacter = alphabet[letterPosition]; // this line now gets the encrypted character as a CHAR
                encryptedMessage[i] = encryptedCharacter; // so we can just pop it directly into the encrypted message!
            }

            string superSecretMessage = String.Join("", encryptedMessage);
            Console.Write(superSecretMessage);
        }
    }
}