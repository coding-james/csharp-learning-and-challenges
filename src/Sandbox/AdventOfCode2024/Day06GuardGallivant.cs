using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Sandbox.AdventOfCode2024
{
    public class Day06GuardGallivant
    {
        // map and then count the locations the guard will go.
        // direction facing ^
        // obstructions = #
        // if an obstruction in front, turn 90 degrees right
        // otherwise step forward
        // stop once guard is off map

        public static int GuardLocations(string map)
        {
            int locations = 0;

            List<List<string>> mapLocations = AddMapBoundary(CleanseMap(map));

            int guardRow = 0;
            int guardCol = 0;
            bool guardInArea = false;
            const string guardUp = "^";
            const string guardRight = ">";
            const string guardDown = "d";
            const string guardLeft = "<";
            string guardDir = guardUp;
            List<string> guardDirections = [guardUp, guardRight, guardDown, guardLeft];
            int searchRow = 0;
            int searchCol = 0;

            // Find the Guard
            // Which way are they facing
            for (int row = 0; row < mapLocations.Count; row++)
            {
                for (int col = 0; col < mapLocations[row].Count; col++)
                {
                    if (guardDirections.Contains(mapLocations[row][col]))
                    {
                        guardRow = row;
                        guardCol = col;
                        guardDir = mapLocations[row][col];
                        guardInArea = true;
                    }
                }
            }

            while (guardInArea)
            {
                // What is in front of them?
                switch (guardDir)
                {
                    case guardUp:
                        searchRow = guardRow - 1;
                        searchCol = guardCol;
                        break;
                    case guardRight:
                        searchRow = guardRow;
                        searchCol = guardCol + 1;
                        break;
                    case guardDown:
                        searchRow = guardRow + 1;
                        searchCol = guardCol;
                        break;
                    default:
                        searchRow = guardRow;
                        searchCol = guardCol - 1;
                        break;

                }

                switch (mapLocations[searchRow][searchCol])
                {
                    case "B":
                        // If Boundary "B", Replace current location with X, add X to count
                        mapLocations[guardRow][guardCol] = "X";
                        locations++;
                        guardInArea = false;
                        break;
                    case ".":
                        // If empty ".", Move forward, Replace current location with X, add X to count
                        mapLocations[0][0] = guardDir; // Next location
                        mapLocations[guardRow][guardCol] = "X";
                        mapLocations[searchRow][searchCol] = guardDir;
                        locations++;
                        break;
                    case "#":
                        // turn 90 right (update), Guard turns 90 and tries again
                        int guardDirIndex = guardDirections.IndexOf(guardDir);
                        if (guardDirIndex < guardDirections.Count - 1)
                        {
                            guardDir = guardDirections[guardDirIndex + 1];
                        }
                        else
                            guardDir = guardDirections[0];
                        break;
                    default:
                        // Guard has previously visited slot, just move on to next location
                        guardRow = searchRow;
                        guardCol = searchCol;
                        break;
                }
            }

            return locations;
        }

        public static List<List<string>> CleanseMap(string input)
        {
            List<List<string>> cleansedMap = new List<List<string>>();

            List<string> firstPass = input.Split(Environment.NewLine).ToList();

            for (int index = 0; index < firstPass.Count; index++)
            {
                List<string> subMap = new List<string>();
                for (int i = 0; i < firstPass[index].Length; i++)
                {
                    subMap.Add(firstPass[index].Substring(i, 1));
                }
                cleansedMap.Add(subMap);
            }

            return cleansedMap;
        }

        public static List<List<string>> AddMapBoundary(List<List<string>> map)
        {
            List<List<string>> updatedMap = new List<List<string>>();
            List<string> top = new List<string>();
            int spacesPerSection = map[0].Count;

            for (int spaces = 0; spaces < spacesPerSection + 2; spaces++)
            {
                top.Add("B");
            }

            updatedMap.Add(top);

            for (int section = 0; section < map.Count; section++)
            {
                List<string> temp = new List<string>();
                temp.Add("B");
                temp.AddRange(map[section]);
                temp.Add("B");
                updatedMap.Add(temp);
            }

            updatedMap.Add(top);

            return updatedMap;
        }
    }
}
