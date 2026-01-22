using Lewis.Logic;
using Shouldly;

namespace TestProject1
{
    public class DigitInspectorTests
    {
        [Theory]
        [InlineData(12345, 15)]
        public void DigitSum_Correct(long num, long expected)
        {
            var di = new DigitInspector(num);
            var result = di.DigitSum();
            result.ShouldBe(expected);
        }

        [Theory]
        [InlineData(12345, 6)]
        public void DigitRoot_Correct_From2Digit_DigitSum(long num, long expected)
        {
            var di = new DigitInspector(num);
            var result = di.DigitRoot();
            result.ShouldBe(expected);
        }

        [Theory]
        [InlineData("999999999999", 108)]
        public void Correct_DigitSum_Has_3Digits(string numStr, long expected)
        {
            var di = new DigitInspector(long.Parse(numStr));
            var result = di.DigitSum();
            result.ShouldBe(expected);

        }

        [Theory]
        [InlineData("999999999999", 9)]
        public void DigitRoot_Correct_From3Digit_DigitSum(string numStr, long expected)
        {
            var di = new DigitInspector(long.Parse(numStr));
            var result = di.DigitRoot();
            result.ShouldBe(expected);
        }

        [Theory]
        [InlineData(-12345)]
        [InlineData(-4)]
        [InlineData(-3)]
        [InlineData(-2)]
        [InlineData(-1)]
        public void DigitInspector_OnlyAccepts_PositiveIntegrs(long negative)
        {
            Should.Throw<ArgumentException>(() =>
            {
                var di = new DigitInspector(negative);
            });
            Should.NotThrow(() =>
            {
                var di = new DigitInspector(0);
                var di2 = new DigitInspector(12345);
            });
        }
    }
}
