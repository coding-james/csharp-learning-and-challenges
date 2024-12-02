using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.AdventOfCode2024
{
    public class Day02RedNosedReports
    {
        public static int HowManySafeReports(List<List<int>> reports)
        {
            int countOfSafe = 0;
            int countOfUnsafe = 0;

            for (int report = 0; report < reports.Count; report++)
            {
                if (IsItSafe(reports[report]))
                {
                    countOfSafe++;
                }
                else
                {
                    countOfUnsafe++;
                }
            }

            return countOfSafe;
        }

        public static int HowManySafeReportsProblemDampener(List<List<int>> reports)
        {
            int countOfSafe = 0;
            int countOfUnsafe = 0;

            for (int report = 0; report < reports.Count; report++)
            {
                if (IsItSafe(reports[report]))
                {
                    countOfSafe++;
                }
                else
                {
                    int reportCount = reports[report].Count;
                    List<bool> outcome = new List<bool>();

                    for (int index = 0; index < reportCount; index++)
                    {
                        List<int> problemDampener = new List<int>();

                        for (int i = 0; i < reports[report].Count; i++)
                        {
                            problemDampener.Add(reports[report][i]);
                        }
                        problemDampener.RemoveAt(index);

                        outcome.Add(IsItSafe(problemDampener));
                    }

                    if (outcome.Where(x => x.Equals(true)).Count() >= 1)
                    {
                        countOfSafe++;
                    }
                    else
                    {
                        countOfUnsafe++;
                    }
                }
            }

            return countOfSafe;
        }

        private static bool IsItSafe(List<int> report)
        {
            int safetyLimitMax = 3;
            int safetyLimitMin = 1;
            int increasing = 0;
            int decreasing = 0;
            int levelsToCheck = report.Count - 1;
            int levelUnsafe = 0;

            for (int level = 0; level < levelsToCheck; level++)
            {
                int num1 = report[level];
                int num2 = report[level + 1];
                int diff = Math.Max(num1, num2) - Math.Min(num1, num2);

                if ((Math.Min(increasing, decreasing) != 0 || diff == 0))
                {
                    levelUnsafe++;
                    break;
                }
                else if (num1 > num2 && diff <= safetyLimitMax && diff >= safetyLimitMin)
                {
                    decreasing++;
                }
                else if (num1 < num2 && diff <= safetyLimitMax && diff >= safetyLimitMin)
                {
                    increasing++;
                }
                else
                {
                    levelUnsafe++;
                    break;
                }
            }

            return Math.Min(increasing, decreasing) == 0 && Math.Max(increasing, decreasing) > 0 && levelUnsafe == 0;
        }
    }
}
