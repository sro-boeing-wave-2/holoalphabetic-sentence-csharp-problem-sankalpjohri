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
                var charactersNotPresent = alphabets.Where(c => !input.Contains(c));
                if (charactersNotPresent.Count() == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
