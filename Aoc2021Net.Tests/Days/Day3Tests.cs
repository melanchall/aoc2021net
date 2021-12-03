using Aoc2021Net.Tests.Attributes;
using NUnit.Framework;

namespace Aoc2021Net.Tests.Days
{
    [DayDataPart1(
        @"00100
          11110
          10110
          10111
          10101
          01111
          00111
          11100
          10000
          11001
          00010
          01010", 198)]
    [DayDataPart1(4006064)]
    [DayDataPart2(
        @"00100
          11110
          10110
          10111
          10101
          01111
          00111
          11100
          10000
          11001
          00010
          01010", 230)]
    [DayDataPart2(5941884)]
    [TestFixture]
    public sealed class Day3Tests : DayTests<Day3Tests>
    {
    }
}
