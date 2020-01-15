using System;

namespace Task2
{
    /// <summary>
    /// A class extending the capabilities of integer types.
    /// </summary>
    public static class IntegerExtensions
    {
        /// <summary>
        /// A method that helps find GCD.
        /// </summary>
        /// <param name="a">First number.</param>
        /// <param name="b">Second numder.</param>
        /// <returns>Greatest common divisor.</returns>
        /// <exception cref="System.ArgumentException">
        /// If both numbers are zero.
        /// </exception>
        /// <exception cref="System.OverflowException">
        /// In case of overflow.
        /// </exception>
        /// <example>
        /// <code>
        /// int result = GetGcd(30, 12);
        /// </code>
        /// </example>
        public static int GetGcd(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                throw new ArgumentException("Two numbers cannot be 0 at the same time.");
            }

            if (a == 0)
            {
                return Math.Abs(b);
            }

            if (b == 0)
            {
                return Math.Abs(a);
            }

            checked
            {
                while (true)
                {
                    if ((a %= b) == 0)
                    {
                        return Math.Abs(b);
                    }
                    else if ((b %= a) == 0)
                    {
                        return Math.Abs(a);
                    }
                }
            }
        }
    }
}