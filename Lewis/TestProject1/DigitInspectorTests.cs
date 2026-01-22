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
        public void DigitRoot_Correct()
        {
            var di = new DigitInspector(12345);
            var result = di.DigitRoot();
            result.ShouldBe(6);
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
