using Sandbox.AdventOfCode2024;
using Sandbox.Tests.AdventOfCode2024Tests.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.AdventOfCode2024Tests
{
    public class Day05PrintQueueTest
    {
        string exampleOne = "47|53\r\n97|13\r\n97|61\r\n97|47\r\n75|29\r\n61|13\r\n75|53\r\n29|13\r\n97|29\r\n53|29\r\n61|53\r\n97|53\r\n61|29\r\n47|13\r\n75|47\r\n97|75\r\n47|61\r\n75|61\r\n47|29\r\n75|13\r\n53|13\r\n\r\n75,47,61,53,29\r\n97,61,53,29,13\r\n75,29,13\r\n75,97,47,61,53\r\n61,13,29\r\n97,13,75,29,47";

        [Fact]
        public void Test_Cleanse()
        {
            List<List<List<int>>> expected = [[[47, 53], [97, 13], [97, 61], [97, 47], [75, 29], [61, 13], [75, 53], [29, 13], [97, 29], [53, 29], [61, 53], [97, 53], [61, 29], [47, 13], [75, 47], [97, 75], [47, 61], [75, 61], [47, 29], [75, 13], [53, 13]], [[75, 47, 61, 53, 29], [97, 61, 53, 29, 13], [75, 29, 13], [75, 97, 47, 61, 53], [61, 13, 29], [97, 13, 75, 29, 47]]];
            Assert.Equal(expected, Day05PrintQueue.Cleanse(exampleOne));
        }

        [Fact]
        public void Test_Example()
        {
            Assert.Equal(143, Day05PrintQueue.GiveMiddleValue(exampleOne));
        }

        [Fact]
        public void Test_Puzzle_Part_One()
        {
            Assert.Equal(7307, Day05PrintQueue.GiveMiddleValue(PuzzleData.DayFive));
        }

        [Fact]
        public void Test_Example_Part_Two()
        {
            Assert.Equal(123, Day05PrintQueue.GiveMiddleValue(exampleOne, true));
        }

        [Fact]
        public void Test_Puzzle_Part_Two()
        {
            Assert.Equal(4713, Day05PrintQueue.GiveMiddleValue(PuzzleData.DayFive, true));
        }
    }
}
