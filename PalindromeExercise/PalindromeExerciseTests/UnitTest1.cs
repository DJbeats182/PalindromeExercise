using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("bob", true)]
        [InlineData("tree", false)]
        [InlineData("palindrome", false)]
        [InlineData("deified", true)]
        [InlineData("redivider", true)]
        public void IsPalindromeTest(string value, bool expected)
        {
            //Arrange
            var test = new WordSmith();
            //Act
            var actual = test.IsPalindrome(value);  
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
