using Lewis.Logic;
using Shouldly;

namespace TestProject1
{
    public class ScramblerTests
    {
        [Fact]
        public void Scrambler_AllPermutations_AllDistinctDigits()
        {
            int og = 123;
            Scrambler scrambler = new Scrambler(og);

            var expectedPermutations = new HashSet<string> { "123", "132", "213", "231", "312", "321"};

            scrambler.GetAllPermutationStrings().SetEquals(expectedPermutations);
        }

        [Fact]
        public void Scrambler_AllPermutations_AllDuplicateDigits()
        {
            int og = 111;
            Scrambler scrambler = new Scrambler(og);

            var expectedPermutations = new HashSet<string> { "111" };

            scrambler.GetAllPermutationStrings().SetEquals(expectedPermutations);
        }

        [Fact]
        public void Scrambler_AllPermutations_SomeDuplicateDigits()
        {
            int og = 112;
            Scrambler scrambler = new Scrambler(og);

            var expectedPermutations = new HashSet<string> { "112", "121", "211" };

            scrambler.GetAllPermutationStrings().SetEquals(expectedPermutations);
        }
    }
}
