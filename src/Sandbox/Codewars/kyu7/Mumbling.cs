using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Codewars.kyu7
{
    public class Mumbling
    {
        public static String Accum(string s)
        {
            int cycle = 1;
            string result = "";

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < cycle; j++)
                {
                    result += j == 0 ? s.Substring(i, 1).ToUpper() : s.Substring(i, 1).ToLower();
                }

                result += i < s.Length - 1 ? "-" : "";
                cycle++;
            }

            return result;
        }
    }
}
