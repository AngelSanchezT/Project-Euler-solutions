using NUnit.Framework;
using ProjectEulerSolutions.EulerProblems;

namespace ProjectEulerSolutions.Tests
{
    [TestFixture]
    public class Problem004Tests
    {
        [Test]
        public void TestSolution()
        {
            // Arrange
            int len = 3;
            long expected = 906609;

            // Act
            long result = Problem004.Solution(len);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestCase(2, 9009)]
        [TestCase(4, 99000099)]
        [TestCase(5, 9966006699)]
        public void TestSolution(int len, long expected)
        {
            // Act
            long result = Problem004.Solution(len);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestIsPalindrome()
        {
            // Arrange
            long num1 = 12321;
            long num2 = 12345;

            // Act
            bool result1 = Problem004.IsPalindrome(num1);
            bool result2 = Problem004.IsPalindrome(num2);

            // Assert
            Assert.IsTrue(result1);
            Assert.IsFalse(result2);
        }
    }
}
