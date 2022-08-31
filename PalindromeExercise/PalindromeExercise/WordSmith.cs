using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsPalindrome(string value)
        {
            var empt = value.Replace(" ", "");
            return empt.ToLower().SequenceEqual(empt.Reverse()); 
        }
    }
}
