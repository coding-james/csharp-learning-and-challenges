using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Sandbox.Codecademy.Projects
{
    public class CaesarCipher
    {
        public static string Encrypt(string message)
        {
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            string messageSanatised = Regex.Replace(message, @"[^a-zA-Z]", "");
            char[] secretMessage = messageSanatised.ToLower().ToCharArray();
            char[] encryptedMessage = new char[secretMessage.Length];

            for (int i = 0; i < secretMessage.Length; i++)
            {
                char charToEncrypt = secretMessage[i];
                int indexInAlphabet = Array.IndexOf(alphabet, charToEncrypt);
                int encryptCharIndex = (indexInAlphabet + 3) % alphabet.Length;
                char encryptChar = alphabet[encryptCharIndex];
                encryptedMessage[i] = encryptChar;
            }

            return String.Join("", encryptedMessage);
        }
    }
}
