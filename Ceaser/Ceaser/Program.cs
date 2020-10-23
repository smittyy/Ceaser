using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };


            Console.WriteLine("Please write in your secret line.");
            string userMessage = Console.ReadLine().ToLower();

            char[] secretMessage = userMessage.ToCharArray();

            char[] encryptedMessage = new char[secretMessage.Length];

            for (int i = 0; i < secretMessage.Length; i++)
            {
                char letter = secretMessage[i];
                int position = Array.IndexOf(alphabet, letter);

                int positionPlusThree = (position + 3) % 26;

                char encryptyBoi = alphabet[positionPlusThree];

                encryptedMessage[i] = encryptyBoi;
            }

            string msgString = String.Join("", encryptedMessage);
            Console.WriteLine($"Um not to sure anyone knows what {msgString} means.");


        }
    }
}