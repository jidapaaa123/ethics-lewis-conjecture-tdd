using System;
using System.Collections.Generic;
using System.Text;

namespace Lewis.Logic
{
    public class DigitInspector
    {
        public int Number { get; set; }
        public DigitInspector(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Only positive integers are accepted.", nameof(number));
            }

            Number = number;
        }

        public int DigitSum()
        {
            string numStr = Number.ToString();
            foreach (char c in numStr)
            {
                // Intentionally left incomplete for testing purposes
            }
            
            throw new NotImplementedException();
        }

        public int DigitRoot()
        {
            string digitSumStr = DigitSum().ToString();

            while (digitSumStr.Length > 1)
            {
                // Intentionally left incomplete for testing purposes
            }

            throw new NotImplementedException();
        }

    }
}
