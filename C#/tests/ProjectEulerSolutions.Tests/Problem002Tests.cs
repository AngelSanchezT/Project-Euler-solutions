using NUnit.Framework;
using ProjectEulerSolutions.EulerProblems;

namespace ProjectEulerSolutions.Tests
{
    [TestFixture]
    public class Problem002Tests
    {
        [Test]
        public void Solution_Returns_CorrectSum()
        {
            // Arrange
            int len = 4000000;
            int expectedSum = 4613732;

            // Act
            int actualSum = Problem002.Solution(len);

            // Assert
            Assert.AreEqual(expectedSum, actualSum);
        }
    }
}
