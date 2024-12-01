using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Sandbox.AdventOfCode
{
    public class Day01HistorianHysteria
    {
        // Pair the lists - smallest number in left with smallest number in the left. Return total difference of each number pair
        public static int TotalDifferences(List<int> listOne, List<int> listTwo)
        {
            int totalDifference = 0;

            listOne.Sort();
            listTwo.Sort();

            for (int i = 0; i < listOne.Count; i++)
            {
                if (listOne[i] > listTwo[i])
                {
                    totalDifference += listOne[i] - listTwo[i];
                }
                else if (listOne[i] < listTwo[i])
                {
                    totalDifference += listTwo[i] - listOne[i];
                }
            }

            return totalDifference;
        }

        // Find the occurance of each number in List One and multiply by occurance in List Two, return total result
        public static int CalcSimilarityScore(List<int> listOne, List<int> listTwo)
        {
            int similarityScore = 0;

            for (int listOneIndex = 0; listOneIndex < listOne.Count; listOneIndex++)
            {
                int count = 0;
                for (int listTwoIndex = 0; listTwoIndex < listTwo.Count; listTwoIndex++)
                {
                    if (listOne[listOneIndex] == listTwo[listTwoIndex])
                    {
                        count++;
                    }
                }
                
                similarityScore += listOne[listOneIndex] * count;
            }

            return similarityScore;
        }
    }
}
