using Lewis.Logic;
using Shouldly;

namespace TestProject1
{
    public class DigitInspectorTests
    {
        [Fact]
        public void DigitSum_Correct()
        {
            var di = new DigitInspector(12345);
            var result = di.DigitSum();
            result.ShouldBe(15);
        }

        [Fact]
        public void DigitRoot_Correct_From2Digit_DigitSum()
        {
            var di = new DigitInspector(12345);
            var result = di.DigitRoot();
            result.ShouldBe(6);
        }

        [Fact]
        public void Correct_DigitSum_Has_3Digits()
        {
            // 9*12 = 108, so make a number that's just 9, 12 times
            var di = new DigitInspector(long.Parse("999999999999"));
            var result = di.DigitSum();
            result.ShouldBe(108);

        }
        [Fact]
        public void DigitRoot_Correct_From3Digit_DigitSum()
        {
            var di = new DigitInspector(long.Parse("999999999999"));
            var result = di.DigitRoot();
            result.ShouldBe(9);
        }

        [Fact]
        public void DigitInspector_OnlyAccepts_PositiveIntegrs()
        {
            Should.Throw<ArgumentException>(() =>
            {
                var di = new DigitInspector(-5);
            });
        }
    }
}
