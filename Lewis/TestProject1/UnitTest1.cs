using Lewis.Logic;
using Shouldly;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Scrambler_AllPermutations()
        {
            int og = 123;
            Scrambler scrambler = new Scrambler(og);

            var expectedPermutations = new List<int> { 123, 132, 213, 231, 312, 321 };

            scrambler.GetAllPermutations().ShouldBe(expectedPermutations);
        }
    }
}
