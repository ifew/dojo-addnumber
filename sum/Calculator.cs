using System;

namespace sum
{
    internal class Calculator
    {
        internal int sum(int[] input)
        {
            int sum = 0;
            for(int length = 0; length < input.Length; length++) {
                sum = sum + input[length];
            }

            return sum;
        }
    }
}