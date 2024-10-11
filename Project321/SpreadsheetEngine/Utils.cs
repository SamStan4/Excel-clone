using System;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace Utils
{
    /// <summary>
    /// Utility class for common functions.
    /// </summary>
    public class Utils
    {
        /// <summary>
        /// Converts integers to base 26 numbers.
        /// </summary>
        /// <param name="num">
        /// The number that we wish to convert.
        /// </param>
        /// <returns>
        /// returns a string.
        /// </returns>
        public static string IntToBase26(int num)
        {
            string result = string.Empty;

            // if the number is zero, throw an exception
            if (num < 0)
            {
                throw new ArgumentException("input number was negative");
            }

            num++; // add one to this to adjust for the zero index

            while (num > 0)
            {
                int remainder = (num - 1) % 26;

                result = (char)(65 + remainder) + result;

                num = (num - 1) / 26;
            }

            return result;
        }

        /// <summary>
        /// Converts our character string into base 10 integer.
        /// </summary>
        /// <param name="num">
        /// This is the number that we are going to be converting.
        /// </param>
        /// <returns>
        /// Returns the integer that we derrived, or throws a fat exception.
        /// </returns>
        public static int Base26ToInt(string num)
        {
            int result = 0;

            // check if the string is empty or null and throw an exception if that is the case
            if (string.IsNullOrEmpty(num))
            {
                throw new ArgumentException("input string was null or empty");
            }
            else if (!num.All(char.IsUpper))
            {
                throw new ArgumentException("input string was not all uppercase characters");
            }

            for (int i = 0; i < num.Length; ++i)
            {
                int cur = num[i] - 'A' + 1;

                result = (result * 26) + cur;
            }

            return result - 1;
        }

        /// <summary>
        /// determines if a string is a valid cell reference.
        /// </summary>
        /// <param name="cellReference">
        /// this is the supposid cell reference.
        /// </param>
        /// <returns>
        /// boolean value that represents if the cell reference is possible or not.
        /// </returns>
        public static bool MatchesCellReferencePattern(string cellReference)
        {
            string regexExpression = @"^[A-Z]+[0-9]+$";

            return Regex.IsMatch(cellReference, regexExpression);
        }
    }
}