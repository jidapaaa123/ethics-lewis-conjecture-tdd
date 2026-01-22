using System;
using System.Collections.Generic;
using System.Text;

namespace Lewis.Logic
{
    public class Scrambler
    {
        public int Number { get; set; }
        public HashSet<string> GetAllPermutationStrings()
        {
            var results = new List<string>();
            string strNumber = Number.ToString();

            // Start the recursive process
            Permute(strNumber.ToCharArray(), 0, results);

            return results.ToHashSet();
        }

        private void Permute(char[] digits, int currentIndex, List<string> results)
        {
            // Base case: if we've reached the end of the array, we have a complete permutation
            // also running this will go outside the array bounds
            if (currentIndex == digits.Length)
            {
                results.Add(new string(digits));
                return;
            }

            // Recursive case: the current index with every index after it
            for (int i = currentIndex; i < digits.Length; i++)
            {
                Swap(digits, currentIndex, i);      // 1. Swap the current element with the loop index
                Permute(digits, currentIndex + 1, results); // 2. Recurse for the next position
                Swap(digits, currentIndex, i);      // 3. Restore original state before this iteration for the next one
            }
        }

        private void Swap(char[] array, int a, int b)
        {
            char temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }

        public Scrambler(int number)
        {
            Number = number;
        }
    }
}
