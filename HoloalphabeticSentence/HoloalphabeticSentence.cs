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
            if (!String.IsNullOrWhiteSpace(input) && !String.IsNullOrWhiteSpace(alphabets))
            {
                input = input.ToLower();
                return alphabets.All(ch => input.Contains(ch));
            }
            return false;
        }
    }
}
