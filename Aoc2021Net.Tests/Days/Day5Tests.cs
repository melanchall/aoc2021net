using Aoc2021Net.Tests.Attributes;
using NUnit.Framework;

namespace Aoc2021Net.Tests.Days
{
    [DayDataPart1(
        @"0,9 -> 5,9
          8,0 -> 0,8
          9,4 -> 3,4
          2,2 -> 2,1
          7,0 -> 7,4
          6,4 -> 2,0
          0,9 -> 2,9
          3,4 -> 1,4
          0,0 -> 8,8
          5,5 -> 8,2", 5)]
    [DayDataPart1(7318)]
    [DayDataPart2(
        @"0,9 -> 5,9
          8,0 -> 0,8
          9,4 -> 3,4
          2,2 -> 2,1
          7,0 -> 7,4
          6,4 -> 2,0
          0,9 -> 2,9
          3,4 -> 1,4
          0,0 -> 8,8
          5,5 -> 8,2", 12)]
    [DayDataPart2(19939)]
    [TestFixture]
    public sealed class Day5Tests : DayTests<Day5Tests>
    {
    }
}
