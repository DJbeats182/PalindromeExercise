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
            return value.SequenceEqual(value.Reverse()); 
        }
    }
}
