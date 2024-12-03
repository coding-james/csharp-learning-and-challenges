using Sandbox.AdventOfCode2024;
using Sandbox.Tests.AdventOfCode2024Tests.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.AdventOfCode2024Tests
{
    public class Day03MullItOverTest
    {
        string examplePart1 = "xmul(2,4)%&mul[3,7]!@^do_not_mul(5,5)+mul(32,64]then(mul(11,8)mul(8,5))";
        string examplePart2 = "xmul(2,4)&mul[3,7]!^don't()_mul(5,5)+mul(32,64](mul(11,8)undo()?mul(8,5))";

        [Fact]
        public void ExamplePartOne_Finds_Correct_Patterns()
        {
            List<string> expectedPatterns = ["mul(2,4)", "mul(5,5)", "mul(11,8)", "mul(8,5)"];
            Assert.Equal(expectedPatterns, Day03MullItOver.FindPatternMatches(examplePart1, false));
        }

        [Fact]
        public void ExamplePartOne()
        {
            Assert.Equal(161, Day03MullItOver.Calc(examplePart1));
        }

        [Fact]
        public void PuzzlePartOne()
        {
            Assert.Equal(178794710, Day03MullItOver.Calc(PuzzleData.DayThree));
        }

        [Fact]
        public void ExamplePartTwo_Finds_Correct_Patterns()
        {
            List<string> expectedPatterns = ["mul(2,4)", "don't()","mul(5,5)", "mul(11,8)", "do()", "mul(8,5)"];
            Assert.Equal(expectedPatterns, Day03MullItOver.FindPatternMatches(examplePart2, true));
        }

        [Fact]
        public void ExamplePartTwo()
        {
            Assert.Equal(48, Day03MullItOver.Calc(examplePart2, true));
        }

        [Fact]
        public void PuzzlePartTwo()
        {
            Assert.Equal(76729637, Day03MullItOver.Calc(PuzzleData.DayThree, true));
        }
    }
}
