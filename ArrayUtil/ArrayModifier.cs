using System;
using System.Collections.Generic;

namespace ArrayUtil
{
    /// <summary>
    /// Class provides a method for filtering an array using any digit
    /// </summary>
    public static class ArrayModifier
    {
        /// <summary>
        /// Returns an array with numbers that contains digit
        /// </summary>
        /// <param name="array">
        /// Array which is needed to be filtered
        /// </param>
        /// <param name="number">
        /// A digit is used like a filter
        /// </param>
        /// <returns>
        /// An array
        /// </returns>
        public static int[] FilterDigits(int[] array, int number)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (number < 0 || number > 9)
            {
                throw new ArgumentException(nameof(number));
            }

            HashSet<int> checker = new HashSet<int>();
            foreach (int x in array)
            {
                if (x.ToString().Contains(number.ToString()))
                {
                    checker.Add(x);
                }
            }

            int[] result = new int[checker.Count];
            int count = 0;
            foreach (int val in checker)
            {
                result[count] = val;
                count++;
            }

            return result;
        }
    }
}
