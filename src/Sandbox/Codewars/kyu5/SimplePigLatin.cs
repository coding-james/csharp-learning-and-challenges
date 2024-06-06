using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Text.RegularExpressions;

namespace Sandbox.Codewars.kyu5
{
    public class SimplePigLatin
    {
        public static string PigIt(string str)
        {
            List<string> words = str.Trim().Split(" ").ToList();
            string result = "";
            //Regex rx = new Regex("[A-Za-z]");

            for (int i = 0; i < words.Count; i++)
            {
                if (words[i].Substring(0, 1).All(Char.IsAsciiLetter))
                //if (rx.IsMatch(words[i].Substring(0, 1))) // Old method for RegExpressions
                {
                    string start = words[i].Substring(0, 1);
                    string body = words[i].Substring(1, words[i].Length - 1);
                    string tmp = $"{body}{start}{"ay"}";

                    words[i] = tmp;
                }
            }

            for (int i = 0; i < words.Count; i++)
            {
                result += i != words.Count - 1 ? words[i] + " " : words[i];
            }

            return result;
        }
    }
}
