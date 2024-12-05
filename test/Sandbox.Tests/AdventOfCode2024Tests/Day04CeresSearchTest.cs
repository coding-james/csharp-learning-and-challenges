using Sandbox.AdventOfCode2024;
using Sandbox.Tests.AdventOfCode2024Tests.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.AdventOfCode2024Tests
{
    public class Day04CeresSearchTest
    {
        string exampleOne = "..X...\r\n.SAMX.\r\n.A..A.\r\nXMAS.S\r\n.X....";
        string exampleTwo = "MMMSXXMASM\r\nMSAMXMSMSA\r\nAMXSXMAAMM\r\nMSAMASMSMX\r\nXMASAMXAMM\r\nXXAMMXXAMA\r\nSMSMSASXSS\r\nSAXAMASAAA\r\nMAMMMXMMMM\r\nMXMXAXMASX";
        string exampleThree = "CcXxma\r\n.SAMX.\r\n.A..A.\r\nXMAS.S\r\n.X....";

        List<string> expectedCleanseOneAndThree = ["..X...", ".SAMX.", ".A..A.", "XMAS.S", ".X...."];
        List<string> expectedCleanseTwo = ["MMMSXXMASM", "MSAMXMSMSA", "AMXSXMAAMM", "MSAMASMSMX", "XMASAMXAMM", "XXAMMXXAMA", "SMSMSASXSS", "SAXAMASAAA", "MAMMMXMMMM", "MXMXAXMASX"];

        List<List<string>> expectedBreakdownThree = [
            [".",".","X",".",".","."],
            [".","S","A","M","X","."], 
            [".","A",".",".","A","."],
            ["X","M","A","S",".","S"], 
            [".","X",".",".",".","."]];

        [Fact]
        public void Cleanse_Test_Example_One()
        {
            Assert.Equal(expectedCleanseOneAndThree, Day04CeresSearch.Cleanse(exampleOne));
        }

        [Fact]
        public void Cleanse_Test_Example_Two()
        {
            Assert.Equal(expectedCleanseTwo, Day04CeresSearch.Cleanse(exampleTwo));
        }

        [Fact]
        public void Cleanse_Test_Example_Three()
        {
            Assert.Equal(expectedCleanseOneAndThree, Day04CeresSearch.Cleanse(exampleThree));
        }

        [Fact]
        public void Breakdown_Test_Expected_Three()
        {
            Assert.Equal(expectedBreakdownThree, Day04CeresSearch.Breakdown(expectedCleanseOneAndThree));
        }

        [Theory]
        [InlineData("------\r\n------\r\n------\r\n------\r\n------", 0)] // None
        [InlineData("Xabcde\r\nMabcde\r\nAabcde\r\nSabcde\r\nabcdef", 1)] // Single Column
        [InlineData("------\r\n-----S\r\n-----A\r\n-----M\r\n-----X", 1)] // Single Column Reverse
        [InlineData("XMASS_\r\nabcdef\r\nabcdef\r\nabcdef\r\nabcdef", 1)] // Single Row
        [InlineData("------\r\n------\r\n------\r\n------\r\n--SAMX", 1)] // Single Row Reverse
        [InlineData("X----S\r\n-M----\r\n--A---\r\n---S--\r\n------", 1)] // Single L to R Down
        [InlineData("------\r\n--S---\r\n---A--\r\n----M-\r\n-----X", 1)] // Single L to R Down Reverse
        [InlineData("------\r\n---S--\r\n--A---\r\n-M----\r\nX-----", 1)] // Single L to R Up
        [InlineData("------\r\n-----X\r\n----M-\r\n---A--\r\n--S---", 1)] // Single L to R Up Reverse
        [InlineData("CcXxma\r\n.SAMX.\r\n.A..A.\r\nXMAS.S\r\n.X....", 4)]
        [InlineData("MMMSXXMASM\r\nMSAMXMSMSA\r\nAMXSXMAAMM\r\nMSAMASMSMX\r\nXMASAMXAMM\r\nXXAMMXXAMA\r\nSMSMSASXSS\r\nSAXAMASAAA\r\nMAMMMXMMMM\r\nMXMXAXMASX", 18)]
        public void FindXmas_Test(string input, int expected)
        {
            Assert.Equal(expected, Day04CeresSearch.FindXmas(input));
        }

        [Fact]
        public void FindXmas_Puzzle_Test()
        {
            Assert.Equal(2718, Day04CeresSearch.FindXmas(PuzzleData.DayFour));
        }

        [Theory]
        [InlineData("..........\r\n..........\r\n..........\r\n..........\r\n..........\r\n..........\r\n..........\r\n..........\r\n..........\r\n..........", 0)]
        [InlineData("M.M.......\r\n.A........\r\nS.S.......\r\n..........\r\n..........\r\n..........\r\n..........\r\n..........\r\n..........\r\n..........", 1)] // ["M", "M", "A", "S", "S"] 
        [InlineData("M.S.......\r\n.A........\r\nM.S.......\r\n..........\r\n..........\r\n..........\r\n..........\r\n..........\r\n..........\r\n..........", 1)] // ["M", "S", "A", "M", "S"] // not working
        [InlineData("..........\r\n..........\r\n..........\r\n..........\r\n..........\r\n..........\r\n..........\r\n.......S.S\r\n........A.\r\n.......M.M", 1)] // ["S", "S", "A", "M", "M"]
        [InlineData("..........\r\n.S.M......\r\n..A.......\r\n.S.M......\r\n..........\r\n..........\r\n..........\r\n..........\r\n..........\r\n..........", 1)] // ["S", "M", "A", "S", "M"] // not working
        [InlineData(".M.S......\r\n..A..MSMS.\r\n.M.S.MAA..\r\n..A.ASMSM.\r\n.M.S.M....\r\n..........\r\nS.S.S.S.S.\r\n.A.A.A.A..\r\nM.M.M.M.M.\r\n..........", 9)]
        public void FindMasX_Test(string input, int expected)
        {
            Assert.Equal(expected, Day04CeresSearch.FindMasX(input));
        }

        [Fact]
        public void FindMasX_Puzzle_Test()
        {
            Assert.Equal(2046, Day04CeresSearch.FindMasX(PuzzleData.DayFour));
        }
    }
}
