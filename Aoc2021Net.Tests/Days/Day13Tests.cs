using Aoc2021Net.Tests.Attributes;
using NUnit.Framework;

namespace Aoc2021Net.Tests.Days
{
    [DayDataPart1(
        @"6,10
          0,14
          9,10
          0,3
          10,4
          4,11
          6,0
          6,12
          4,1
          0,13
          10,12
          3,4
          3,0
          8,4
          1,10
          2,14
          8,10
          9,0
          
          fold along y=7
          fold along x=5", 17)]
    [DayDataPart1(759)]
    [DayDataPart2(
        @"6,10
          0,14
          9,10
          0,3
          10,4
          4,11
          6,0
          6,12
          4,1
          0,13
          10,12
          3,4
          3,0
          8,4
          1,10
          2,14
          8,10
          9,0
          
          fold along y=7
          fold along x=5", @"#####
#...#
#...#
#...#
#####")]
    [DayDataPart2(@"#..#.####..##..###..####.#..#.###..###.
#..#.#....#..#.#..#....#.#.#..#..#.#..#
####.###..#....#..#...#..##...#..#.#..#
#..#.#....#....###...#...#.#..###..###.
#..#.#....#..#.#.#..#....#.#..#....#.#.
#..#.####..##..#..#.####.#..#.#....#..#")]
    [TestFixture]
    public sealed class Day13Tests : DayTests<Day13Tests>
    {
    }
}
