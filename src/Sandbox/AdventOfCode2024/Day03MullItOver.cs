using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Sandbox.AdventOfCode2024
{
    public class Day03MullItOver
    {
        public static int Calc(string input, bool conditionsEnabled = false)
        {
            int result = 0;
            bool selector = true; 

            List<string> matches = FindPatternMatches(input, conditionsEnabled);

            foreach (string match in matches)
            {
                if (match == "do()" && conditionsEnabled)
                {
                    selector = true;
                }
                else if (match == "don't()" && conditionsEnabled)
                {
                    selector = false;
                }
                else if (selector)
                {
                    string[] numbers = match.Split(",");
                    result += int.Parse(Regex.Replace(numbers[0], @"[^0-9]", "")) * int.Parse(Regex.Replace(numbers[1], @"[^0-9]", ""));
                }
                else
                {
                    continue;
                }
                
            }

            return result;
        }

        public static List<string> FindPatternMatches(string input, bool conditionsEnabled)
        {
            List<string> matchList = new List<string>();
            MatchCollection matches;

            if (conditionsEnabled)
            {
                matches = Regex.Matches(input, @"mul\(\d+,\d+\)|do\(\)|don't\(\)");
            }
            else
            {
                matches = Regex.Matches(input, @"mul\(\d+,\d+\)");
            }         

            foreach (Match match in matches)
            {
                matchList.Add(match.Value);
            }
            return matchList;
        }
    }
}
