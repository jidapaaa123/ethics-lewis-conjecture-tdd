using Lewis.Logic;
using Shouldly;

namespace TestProject1
{
    public class LewisConjectureTests
    {
        [Fact]
        public void LewisConjecture_HoldsForFirstMillionNumbers()
        {
            const int limit = 1_000_000;
            for (int n = 1; n <= limit; n++)
            {
                HashSet<string> permutationStrings = new Scrambler(n).GetAllPermutationStrings();
                if (permutationStrings.Count == 0)
                {
                    continue;
                }

                List<long> absoluteDifferences = permutationStrings
                        .Select(str => long.Parse(str))
                        .Where(scr => scr != n)
                        .Select(scr => Math.Abs(scr - n))
                        .ToList();

                List<long> digitRootsOfDifferences = absoluteDifferences
                        .Select(diff => new DigitInspector(diff).DigitRoot())
                        .ToList();

                bool anyNonNineRoots = digitRootsOfDifferences.Any(root => root != 9);

                anyNonNineRoots.ShouldBeFalse($"Lewis Conjecture failed for number {n}");
            }
        }

    }
}
