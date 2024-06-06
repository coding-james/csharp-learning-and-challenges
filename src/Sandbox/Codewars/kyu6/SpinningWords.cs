using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Codewars.kyu6
{
    public class SpinningWords
    {
        public static String SpinWords(string sentence)
        {
            List<string> words = sentence.Trim().Split(" ").ToList();
            string result = "";

            for (int i = 0; i < words.Count; i++)
            {
                if (words[i].Length >= 5)
                {
                    string tmp = "";
                    for (int j = words[i].Length - 1; j > -1; j--)
                    {
                        tmp += words[i].Substring(j, 1);
                    }

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
