using NUnit.Framework;
using ProjectEulerSolutions.EulerProblems;

namespace ProjectEulerSolutions.Tests
{
    [TestFixture]
    public class Problem001Tests
    {
        [Test]
        public void TestSolution()
        {
            // Arrange
            int expectedSum = 23;

            // Act
            int actualSum = Problem001.Solution(10);

            // Assert
            Assert.AreEqual(expectedSum, actualSum);
        }
    }
}
