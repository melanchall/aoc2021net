using Aoc2021Net.Tests.Attributes;
using NUnit.Framework;

namespace Aoc2021Net.Tests.Days
{
    [DayDataPart1(
        @"start-A
          start-b
          A-c
          A-b
          b-d
          A-end
          b-end", 10)]
    [DayDataPart1(
        @"dc-end
          HN-start
          start-kj
          dc-start
          dc-HN
          LN-dc
          HN-end
          kj-sa
          kj-HN
          kj-dc", 19)]
    [DayDataPart1(
        @"fs-end
          he-DX
          fs-he
          start-DX
          pj-DX
          end-zg
          zg-sl
          zg-pj
          pj-he
          RW-he
          fs-DX
          pj-RW
          zg-RW
          start-pj
          he-WI
          zg-he
          pj-fs
          start-RW", 226)]
    [DayDataPart1(3292)]
    [DayDataPart2(
        @"start-A
          start-b
          A-c
          A-b
          b-d
          A-end
          b-end", 36)]
    [DayDataPart2(
        @"dc-end
          HN-start
          start-kj
          dc-start
          dc-HN
          LN-dc
          HN-end
          kj-sa
          kj-HN
          kj-dc", 103)]
    [DayDataPart2(
        @"fs-end
          he-DX
          fs-he
          start-DX
          pj-DX
          end-zg
          zg-sl
          zg-pj
          pj-he
          RW-he
          fs-DX
          pj-RW
          zg-RW
          start-pj
          he-WI
          zg-he
          pj-fs
          start-RW", 3509)]
    [DayDataPart2(89592)]
    [TestFixture]
    public sealed class Day12Tests : DayTests<Day12Tests>
    {
    }
}
