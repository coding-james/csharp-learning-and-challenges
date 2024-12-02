using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sandbox.AdventOfCode2024;
using Sandbox.Tests.AdventOfCode2024Tests.Data;

namespace Sandbox.Tests.AdventOfCode2024Tests
{
    public class Day02RedNosedReportsTest
    {
        List<List<int>> exampleReports = [[7, 6, 4, 2, 1], [1, 2, 7, 8, 9], [9, 7, 6, 2, 1], [1, 3, 2, 4, 5], [8, 6, 4, 4, 1], [1, 3, 6, 7, 9]];
        List<List<int>> puzzleReports = PuzzleData.DayTwoList;

        [Fact]
        public void ExampleData_Safe_Or_Unsafe()
        {
            Assert.Equal(2, Day02RedNosedReports.HowManySafeReports(exampleReports));
        }

        [Fact]
        public void PuzzleData_Safe_Or_Unsafe()
        {
            Assert.Equal(564, Day02RedNosedReports.HowManySafeReports(puzzleReports));
        }

        [Fact]
        public void ExampleData_Safe_Or_Unsafe_Problem_Dampener()
        {
            Assert.Equal(4, Day02RedNosedReports.HowManySafeReportsProblemDampener(exampleReports));
        }

        [Fact]
        public void PuzzleData_Safe_Or_Unsafe_Problem_Dampener()
        {
            Assert.Equal(604, Day02RedNosedReports.HowManySafeReportsProblemDampener(puzzleReports));
        }
    }
}
