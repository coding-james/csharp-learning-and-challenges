using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Codewars.kyu6
{
    // CODEWARS: Roman Numerals Decoder
    public class RomanDecode
    {
        public static int Solution(string roman)
        {
            string toDecode = roman;
            int result = 0;
            List<string> segmentRoman = new List<string>();
            List<string> romStr = new List<string>() { "M", "MM", "MMM", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            List<int> romInt = new List<int>() { 1000, 2000, 3000, 100, 200, 300, 400, 500, 600, 700, 800, 900, 10, 20, 30, 40, 50, 60, 70, 80, 90, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            if (toDecode[0] == Char.Parse("M"))
            {
                    if (toDecode.Length >= 3 && toDecode.Substring(0, 3) == "MMM")
                    {
                        result += 3000;
                        toDecode = toDecode.Length != 3 ? toDecode.Substring(3) : "";
                    }
                    else if (toDecode.Length >= 2 && toDecode.Substring(0, 2) == "MM")
                    {
                        result += 2000;
                        toDecode = toDecode.Length != 2 ? toDecode.Substring(2) : "";
                    }
                    else
                    {
                        result += 1000;
                        toDecode = toDecode.Length != 1 ? toDecode.Substring(1) : "";
                    }
            }

            while (toDecode.Length > 0)
            {
                for (int i = Math.Min(4, toDecode.Length); i > 0; i--)
                {
                    if (romStr.Contains(toDecode.Substring(0, i)) && i != toDecode.Length)
                    {
                        segmentRoman.Add(toDecode.Substring(0, i));
                        toDecode = toDecode.Substring(i);
                        break;
                    }
                    else if (romStr.Contains(toDecode.Substring(0, i)))
                    {
                        segmentRoman.Add(toDecode.Substring(0, i));
                        toDecode = "";
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            if (segmentRoman.Count > 0)
            {
                foreach (string segment in segmentRoman)
                {
                    result += romInt[romStr.IndexOf(segment)];
                }
            }

            return result;
        }
    }
}
