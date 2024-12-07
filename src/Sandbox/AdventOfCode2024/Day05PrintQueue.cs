using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.AdventOfCode2024
{
    public class Day05PrintQueue
    {

        public static int GiveMiddleValue(string input, bool giveCorrectedOnly = false)
        {
            int result = 0;
            List<List<int>> ordersRules = new List<List<int>>();
            List<List<int>> printOrder = new List<List<int>>();
            List<List<int>> correctPrintOrder = new List<List<int>>();
            List<List<int>> updatedPrintOrder = new List<List<int>>();
            List<List<List<int>>> cleansed = Cleanse(input);
            List<bool> results = new List<bool>();
            bool isUpdatedInValid = true;

            ordersRules = cleansed[0];
            printOrder = cleansed[1];

            for (int printIndex = 0; printIndex < printOrder.Count; printIndex++)
            {
                bool isOriginalValid = true;

                for (int ruleIndex = 0; ruleIndex < ordersRules.Count; ruleIndex++)
                {
                    {
                        int ruleOne = ordersRules[ruleIndex][0];
                        int ruleTwo = ordersRules[ruleIndex][1];

                        if (printOrder[printIndex].Contains(ruleOne) && printOrder[printIndex].Contains(ruleTwo))
                        {
                            int indexOfFirst = printOrder[printIndex].IndexOf(ruleOne);
                            int indexOfSecond = printOrder[printIndex].IndexOf(ruleTwo);

                            if (indexOfFirst > indexOfSecond)
                            {
                                isOriginalValid = false;
                                if (giveCorrectedOnly)
                                {
                                    printOrder[printIndex][indexOfFirst] = ruleTwo;
                                    printOrder[printIndex][indexOfSecond] = ruleOne;
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                    }
                }

                if (isOriginalValid)
                {
                    correctPrintOrder.Add(printOrder[printIndex]);
                }
                else
                {
                    updatedPrintOrder.Add(printOrder[printIndex]);
                }
            }

            if (giveCorrectedOnly)
            {
                while (isUpdatedInValid)
                {
                    results.Clear();
                    for (int printIndex = 0; printIndex < updatedPrintOrder.Count; printIndex++)
                    {
                        for (int ruleIndex = 0; ruleIndex < ordersRules.Count; ruleIndex++)
                        {
                            {
                                int ruleOne = ordersRules[ruleIndex][0];
                                int ruleTwo = ordersRules[ruleIndex][1];

                                if (updatedPrintOrder[printIndex].Contains(ruleOne) && updatedPrintOrder[printIndex].Contains(ruleTwo))
                                {
                                    int indexOfFirst = updatedPrintOrder[printIndex].IndexOf(ruleOne);
                                    int indexOfSecond = updatedPrintOrder[printIndex].IndexOf(ruleTwo);

                                    if (indexOfFirst > indexOfSecond)
                                    {
                                        results.Add(false);
                                        updatedPrintOrder[printIndex][indexOfFirst] = ruleTwo;
                                        updatedPrintOrder[printIndex][indexOfSecond] = ruleOne;
                                    }
                                    else
                                    {
                                        results.Add(true);
                                    }
                                }
                            }
                        }
                    }
                    if (results.Contains(false))
                    {
                        isUpdatedInValid = true;
                    }
                    else
                    {
                        isUpdatedInValid = false;
                    }
                }
                return CalcMiddleValue(updatedPrintOrder);
            }

            return CalcMiddleValue(correctPrintOrder);
        }

        //Cleanse the input
        public static List<List<List<int>>> Cleanse(string input)
        {
            List<List<List<int>>> cleansed = new List<List<List<int>>>();
            List<List<int>> cleansedRules = new List<List<int>>();
            List<List<int>> cleansedPages = new List<List<int>>();

            List<string> firstPass = input.Split(Environment.NewLine).ToList();

            for (int index = 0; index < firstPass.Count; index++)
            {
                if (firstPass[index].Contains("|"))
                {
                    List<int> tempRules = new List<int>();
                    string tempStr = firstPass[index];
                    int dividerIndex = tempStr.IndexOf("|");
                    tempRules.Add(int.Parse(tempStr.Substring(0, dividerIndex)));
                    tempRules.Add(int.Parse(tempStr.Substring(dividerIndex + 1)));
                    cleansedRules.Add(tempRules);
                }
                else if (firstPass[index] != "")
                {
                    List<int> tempOrderNum = new List<int>();
                    List<string> tempOrder = firstPass[index].Split(",").ToList();
                    foreach (var item in tempOrder)
                    {
                        tempOrderNum.Add(int.Parse(item));
                    }
                    cleansedPages.Add(tempOrderNum);
                }
            }
            cleansed.Add(cleansedRules);
            cleansed.Add(cleansedPages);

            return cleansed;
        }

        public static int CalcMiddleValue(List<List<int>> printOrder)
        {
            int result = 0;

            for (int printIndex = 0; printIndex < printOrder.Count; printIndex++)
            {
                int middle = printOrder[printIndex].Count / 2;
                result += printOrder[printIndex][middle];
            }

            return result;
        }
    }
}
