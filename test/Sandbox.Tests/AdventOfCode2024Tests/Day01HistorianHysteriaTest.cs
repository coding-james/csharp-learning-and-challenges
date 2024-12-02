using Sandbox.AdventOfCode;
using Sandbox.Tests.AdventOfCode2024Tests.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.AdventOfCode2024Tests
{
    public class Day01HistorianHysteriaTest
    {
        List<int> exampleList1 = [3, 4, 2, 1, 3, 3];
        List<int> exampleList2 = [4, 3, 5, 3, 9, 3];
        List<int> puzzleListOne = PuzzleData.DayOneListOne;
        List<int> puzzleListTwo = PuzzleData.DayOneListTwo;

        [Fact]
        public void CheckExample()
        {
            var differences = Day01HistorianHysteria.TotalDifferences(exampleList1, exampleList2);
            Assert.Equal(11, differences);
        }

        [Fact]
        public void CheckPuzzle()
        {
            var differences = Day01HistorianHysteria.TotalDifferences(puzzleListOne, puzzleListTwo);
            Assert.Equal(1197984, differences);
        }

        [Fact]
        public void CheckExamplePartTwo()
        {
            var similarityScore = Day01HistorianHysteria.CalcSimilarityScore(exampleList1, exampleList2);
            Assert.Equal(31, similarityScore);
        }

        [Fact]
        public void CheckPuzzlePartTwo()
        {
            var similarityScore = Day01HistorianHysteria.CalcSimilarityScore(puzzleListOne, puzzleListTwo);
            Assert.Equal(23387399, similarityScore);
        }
    }
}
