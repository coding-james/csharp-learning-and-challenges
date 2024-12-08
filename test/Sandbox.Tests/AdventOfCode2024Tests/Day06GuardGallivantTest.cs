using Sandbox.AdventOfCode2024;
using Sandbox.Tests.AdventOfCode2024Tests.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.AdventOfCode2024Tests
{
    public class Day06GuardGallivantTest
    {
        string example = "....#.....\r\n.........#\r\n..........\r\n..#.......\r\n.......#..\r\n..........\r\n.#..^.....\r\n........#.\r\n#.........\r\n......#...";

        List<List<string>> expectedCleansedMap = [
                [".", ".", ".", ".", "#", ".", ".", ".", ".", "."],
                [".", ".", ".", ".", ".", ".", ".", ".", ".", "#"],
                [".", ".", ".", ".", ".", ".", ".", ".", ".", "."],
                [".", ".", "#", ".", ".", ".", ".", ".", ".", "."],
                [".", ".", ".", ".", ".", ".", ".", "#", ".", "."],
                [".", ".", ".", ".", ".", ".", ".", ".", ".", "."],
                [".", "#", ".", ".", "^", ".", ".", ".", ".", "."],
                [".", ".", ".", ".", ".", ".", ".", ".", "#", "."],
                ["#", ".", ".", ".", ".", ".", ".", ".", ".", "."],
                [".", ".", ".", ".", ".", ".", "#", ".", ".", "."]
                ];

        List<List<string>> expectedMapWithBoundary = [
                ["B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B"],
                ["B", ".", ".", ".", ".", "#", ".", ".", ".", ".", ".", "B"],
                ["B", ".", ".", ".", ".", ".", ".", ".", ".", ".", "#", "B"],
                ["B", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "B"],
                ["B", ".", ".", "#", ".", ".", ".", ".", ".", ".", ".", "B"],
                ["B", ".", ".", ".", ".", ".", ".", ".", "#", ".", ".", "B"],
                ["B", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "B"],
                ["B", ".", "#", ".", ".", "^", ".", ".", ".", ".", ".", "B"],
                ["B", ".", ".", ".", ".", ".", ".", ".", ".", "#", ".", "B"],
                ["B", "#", ".", ".", ".", ".", ".", ".", ".", ".", ".", "B"],
                ["B", ".", ".", ".", ".", ".", ".", "#", ".", ".", ".", "B"],
                ["B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B"]
                ];

        [Fact]
        public void Test_Cleanse()
        {
            Assert.Equal(expectedCleansedMap, Day06GuardGallivant.CleanseMap(example));
        }

        [Fact]
        public void Test_AddMapBoundary()
        {
            Assert.Equal(expectedMapWithBoundary, Day06GuardGallivant.AddMapBoundary(expectedCleansedMap));
        }

        [Fact]
        public void Test_GuardLocations_Example()
        {
            Assert.Equal(41, Day06GuardGallivant.GuardLocations(example));
        }

        [Fact]
        public void Test_GuardLocations_PuzzlePartOne()
        {
            Assert.Equal(5162, Day06GuardGallivant.GuardLocations(PuzzleData.Day06));
        }
    }
}
