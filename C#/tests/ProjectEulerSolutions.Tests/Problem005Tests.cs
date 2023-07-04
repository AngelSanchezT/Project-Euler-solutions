using NUnit.Framework;
using ProjectEulerSolutions.EulerProblems;

namespace ProjectEulerSolutions.Tests
{
    [TestFixture]
    public class Problem005Tests
    {
        [Test]
        public void Solution_ReturnsCorrectResult()
        {
            // Arrange
            long min = 1;
            long max = 10;
            long expected = 2520;

            // Act
            long result = Problem005.Solution(min, max);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsPalindrome_ReturnsTrue_ForPalindromeNumber()
        {
            // Arrange
            long num = 12321;

            // Act
            bool result = Problem005.IsPalindrome(num);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindrome_ReturnsFalse_ForNonPalindromeNumber()
        {
            // Arrange
            long num = 12345;

            // Act
            bool result = Problem005.IsPalindrome(num);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
