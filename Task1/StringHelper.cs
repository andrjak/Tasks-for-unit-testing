using System;

namespace Task1
{
    /// <summary>
    /// Class that helps to work with string.
    /// </summary>
    public static class StringHelper
    {
        /// <summary>
        /// Method for counting vowels in a string.
        /// </summary>
        /// <param name="str">Vowel search string.</param>
        /// <returns>Number of vowels per line.</returns>
        /// <exception cref="System.ArgumentNullException">
        /// If the line == null.
        /// </exception>
        /// <exception cref="System.ArgumentException">
        /// If the line is empty.
        /// </exception>
        /// <example>
        /// <code>
        /// int count = GetVowelCount("example");
        /// </code>
        /// </example>
        public static int GetVowelCount(string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str), "String cannot be null.");
            }

            if (str.Length == 0)
            {
                throw new ArgumentException("String cannot be empty.");
            }

            int counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
