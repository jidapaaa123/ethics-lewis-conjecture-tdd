using System;
using System.Collections.Generic;
using System.Text;

namespace Lewis.Logic
{
    public class DigitInspector
    {
        public long Number { get; set; }
        public DigitInspector(long number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Only positive longegers are accepted.", nameof(number));
            }

            Number = number;
        }

        public long DigitSum()
        {
            string numStr = Number.ToString();
            long sum = 0;
            foreach (char c in numStr)
            {
                long charNum = long.Parse(c.ToString());
                sum += charNum;
            }

            return sum;
        }

        public long DigitRoot()
        {
            string digitSumStr = DigitSum().ToString();

            while (digitSumStr.Length > 1)
            {
                digitSumStr = new DigitInspector(long.Parse(digitSumStr))
                    .DigitSum()
                    .ToString();
            }

            return long.Parse(digitSumStr);
        }

    }
}
