using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;

namespace Sandbox.AdventOfCode2024
{
    public class Day04CeresSearch
    {

        public static int FindXmas(string input)
        {
            int countOfPattern = 0;
            List<List<string>> searchPatterns = [["X", "M", "A", "S"], ["S", "A", "M", "X"]];
            
            List<List<string>> searchList = Breakdown(Cleanse(input));

            int rowsToSearch = searchList.Count;
            int columnsToSearch = searchList[0].Count;
            int searchPatternLength = searchPatterns[0].Count;
            int rowsToSearchLimited = (rowsToSearch - searchPatternLength);
            int columnsToSearchLimited = columnsToSearch - searchPatternLength;

            for (int pattern = 0; pattern < searchPatterns.Count; pattern++)
            {
                // Horizontal
                for (int row = 0; row < rowsToSearch; row++)
                {
                    for (int col = 0; col <= columnsToSearchLimited; col++)
                    {
                        if (Search(row, col, row, col + 1, row, col + 2, row, col + 3, searchList, searchPatterns[pattern]))
                        {
                            countOfPattern++;
                        }
                    }
                }

                // Vertical    
                for (int col = 0; col < columnsToSearch; col++)
                {

                    for (int row = 0; row <= rowsToSearchLimited; row++)
                    {
                        if (Search(row, col, row + 1, col, row + 2, col, row + 3, col, searchList, searchPatterns[pattern]))
                        {
                            countOfPattern++;
                        }
                    }
                }

                for (int col = 0; col <= columnsToSearchLimited; col++)
                {

                    for (int row = 0; row <= rowsToSearchLimited; row++)
                    {
                        // Diagonal Down L to R
                        if (Search(row, col, row + 1, col + 1, row + 2, col + 2, row + 3, col + 3, searchList, searchPatterns[pattern]))
                        {
                            countOfPattern++;
                        }

                        // Diagonal Up L to R
                        if (Search(row + 3, col, row + 2, col + 1, row + 1, col + 2, row + 0, col + 3, searchList, searchPatterns[pattern]))
                        {
                            countOfPattern++;
                        }
                    }
                }
            }

                
            return countOfPattern;
        }

        public static int FindMasX(string input)
        {
            int countOfPattern = 0;
            List<List<string>> searchPatterns = [["M", "M", "A", "S", "S"], ["M", "S", "A", "M", "S"], ["S", "S", "A", "M", "M"], ["S", "M", "A", "S", "M"]];

            List<List<string>> searchList = Breakdown(CleanseX(input));

            int rowsToSearch = searchList.Count - 2;
            int columnsToSearch = searchList[0].Count - 2;

            for (int pattern = 0; pattern < searchPatterns.Count; pattern++)
            {
                for (int col = 0; col < columnsToSearch; col++)
                {
                    for (int row = 0; row < rowsToSearch; row++)
                    {
                        if (SearchX(row, col, row, col + 2, row + 1, col + 1, row + 2, col, row + 2, col + 2, searchList, searchPatterns[pattern]))
                        {
                            countOfPattern++;
                        }
                    }
                }
            }

            return countOfPattern;
        }

        //Replace all the letters not in XMAS and break into words
        public static List<string> Cleanse(string input)
        {
            List<string> cleansedList = input.Split(Environment.NewLine).ToList();

            for (int index = 0; index < cleansedList.Count; index++)
            {
                cleansedList[index] = Regex.Replace(cleansedList[index], @"[^XMAS]", ".");
            }

            return cleansedList;
        }

        //Replace all the letters not in MAS and break into words
        public static List<string> CleanseX(string input)
        {
            List<string> cleansedList = input.Split(Environment.NewLine).ToList();

            for (int index = 0; index < cleansedList.Count; index++)
            {
                cleansedList[index] = Regex.Replace(cleansedList[index], @"[^MAS]", ".");
            }

            return cleansedList;
        }

        //Breakdown into individual characters
        public static List<List<String>> Breakdown(List<string> input)
        {

            List<List<string>> list = new List<List<string>>();

            for (int index = 0; index < input.Count; index++)
            {
                string sub = input[index];
                List<string> sublist = new List<string>();
                for (int subIndex = 0; subIndex < sub.Length; subIndex++)
                {
                    sublist.Add(sub.Substring(subIndex, 1));
                }
                list.Add(sublist);
            }

            return list;
        }

        // Search
        public static bool Search(int row0, int col0, int row1, int col1, int row2, int col2, int row3, int col3, List<List<string>> searchList, List<string> searchPattern)
        {

            return searchList[row0][col0] == searchPattern[0]
                   && searchList[row1][col1] == searchPattern[1]
                   && searchList[row2][col2] == searchPattern[2]
                   && searchList[row3][col3] == searchPattern[3];
        }

        // Search X Pattern
        public static bool SearchX(int topLeftRow, int topLeftCol, int topRightRow, int topRightCol, int centerRow, int centerCol, int bottomLeftRow, int bottomLeftCol, int bottomRightRow, int bottomRightCol, List<List<string>> searchList, List<string> searchPattern)
        {
            return searchList[topLeftRow][topLeftCol] == searchPattern[0]
                && searchList[topRightRow][topRightCol] == searchPattern[1]
                && searchList[centerRow][centerCol] == searchPattern[2]
                && searchList[bottomLeftRow][bottomLeftCol] == searchPattern[3]
                && searchList[bottomRightRow][bottomRightCol] == searchPattern[4];

        }
    }
}
