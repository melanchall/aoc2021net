using Aoc2021Net.Tests.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aoc2021Net.Tests.Days
{
    [DayDataPart1(
        @"forward 5
          down 5
          forward 8
          up 3
          down 8
          forward 2", 150)]
    [DayDataPart1(2272262)]
    [DayDataPart2(
        @"forward 5
          down 5
          forward 8
          up 3
          down 8
          forward 2", 900)]
    [DayDataPart2(2134882034)]
    [TestFixture]
    public sealed class Day2Tests : DayTests<Day2Tests>
    {
    }
}
