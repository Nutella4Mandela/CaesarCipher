using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            Console.WriteLine("Create a secret message: ");
            string answer = Console.ReadLine();

            char[] secretMessage = answer.ToCharArray();

            char[] encryptedMessage = new char[secretMessage.Length];

            for (int i = 0; i < secretMessage.Length; i++)
            {
                char letters = secretMessage[i];
                int pos = Array.IndexOf(alphabet, letters);
                int cpos = (pos + 3) % alphabet.Length;
                encryptedMessage[i] = alphabet[cpos];
            }

            String.Join("", encryptedMessage);
            Console.WriteLine(encryptedMessage);
        }
    }
}
