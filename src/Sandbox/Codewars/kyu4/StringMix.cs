using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Sandbox.Codewars.kyu4
{
    public class StringMix
    {
        public static string Mix(string s1, string s2)
        {
            Dictionary<char, int> cleanS1 = CleanText(s1);
            Dictionary<char, int> cleanS2 = CleanText(s2);
            var combined = new List<KeyValuePair<char, int>>();
            List<int> highest = new List<int>();
            List<string> result = new List<string>();
            int index = 0;
            string resultString = "";

            foreach (char ch in cleanS1.Keys)
            {
                if (!cleanS2.ContainsKey(ch) || cleanS2[ch] < cleanS1[ch])
                {
                    combined.Add(new KeyValuePair<char, int>(ch, cleanS1[ch]));
                    highest.Add(1);
                }
                else if (cleanS2[ch] == cleanS1[ch])
                {
                    combined.Add(new KeyValuePair<char, int>(ch, cleanS1[ch]));
                    highest.Add(3);
                }
                else
                {
                    combined.Add(new KeyValuePair<char, int>(ch, cleanS2[ch]));
                    highest.Add(2);
                }
            }

            // For each item in combined, run through CreateCharOccurance()
            foreach (var item in combined)
            {
                if (item.Value > 1)
                {
                    result.Add(CreateCharOccurance(item.Key, item.Value, highest[index]));
                }
                index++;
            }

            // Add in remaining items only in cleanS2
            foreach (char ch in cleanS2.Keys)
            {
                if (!cleanS1.ContainsKey(ch) && cleanS2[ch] > 1)
                {
                    result.Add(CreateCharOccurance(ch, cleanS2[ch], 2));
                }
            }

            result = result.OrderByDescending(x => x.Length).ThenBy(x => x).ToList();

            for (int i = 0; i < result.Count; i++)
            {
                resultString += i != result.Count - 1 ? result[i] + "/" : result[i];
            }

            return resultString.Replace("3", "=");
        }

        private static Dictionary<char, int> CleanText(string s)
        {
            // https://dotnettutorials.net/lesson/character-occurrence-in-a-string-csharp/
            string cleanedText = Regex.Replace(s, "[^a-z]", "").ToLower().Trim();
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char ch in cleanedText)
            {
                if (charCount.ContainsKey(ch))
                {
                    charCount[ch]++;
                }
                else
                {
                    charCount.Add(ch, 1);
                }
            }

            return charCount;
        }

        private static string CreateCharOccurance(char ch, int count, int longest)
        {
            string outcome = "";

            for (int i = 0; i < count; i++)
            {
                outcome += ch;
            }

            switch (longest)
            {
                case 1:
                    return $"1:{outcome}";
                case 2:
                    return $"2:{outcome}";
                default:
                    return $"3:{outcome}";
            }
        }
    }
}
