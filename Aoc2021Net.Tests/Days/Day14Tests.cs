using Aoc2021Net.Tests.Attributes;
using NUnit.Framework;

namespace Aoc2021Net.Tests.Days
{
    [DayDataPart1(
        @"NNCB

          CH -> B
          HH -> N
          CB -> H
          NH -> C
          HB -> C
          HC -> B
          HN -> C
          NN -> C
          BH -> H
          NC -> B
          NB -> B
          BN -> B
          BB -> N
          BC -> B
          CC -> N
          CN -> C", 1588)]
    [DayDataPart1(3048)]
    [DayDataPart2(
        @"NNCB

          CH -> B
          HH -> N
          CB -> H
          NH -> C
          HB -> C
          HC -> B
          HN -> C
          NN -> C
          BH -> H
          NC -> B
          NB -> B
          BN -> B
          BB -> N
          BC -> B
          CC -> N
          CN -> C", 2188189693529)]
    [DayDataPart2(3288891573057)]
    [TestFixture]
    public sealed class Day14Tests : DayTests<Day14Tests>
    {
    }
}
