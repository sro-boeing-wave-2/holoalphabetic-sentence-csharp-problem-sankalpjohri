using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HoloalphabeticSentence
{
    public class HoloalphabeticSentence
    {
        // Write the logic to determine whether the input string is a HoloalphabeticSentence or not
        public static bool IsHoloalphabeticSentence(string input, string alphabets = "abcdefghijklmnopqrstuvwxyz")
        {
            HashSet<char> inputCharSet = new HashSet<char>();
            foreach (char c in input) {
                if (Regex.IsMatch(Char.ToString(c), @"^[A-Za-z]+"))
                {
                    inputCharSet.Add(Char.ToLower(c));
                }
            }
            if (compareChars(inputCharSet, alphabets))
            {
                return true;
            }
            return false;
        }

        private static bool compareChars(HashSet<char> inputSet, string alphabet)
        {
            if (inputSet != null && !String.IsNullOrWhiteSpace(alphabet) && inputSet.Count == alphabet.Length)
            {
                return true;
            }
            return false;
        }
    }
}
