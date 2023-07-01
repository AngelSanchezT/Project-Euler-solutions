using NUnit.Framework;
using ProjectEulerSolutions.EulerProblems;

namespace ProjectEulerSolutions.Tests
{
    [TestFixture]
    public class Problem003Tests
    {
        [Test]
        public void Solution_Returns_CorrectPrimeFactor()
        {
            // Arrange
            double len = 13195;
            long expectedPrimeFactor = 29;

            // Act
            long actualPrimeFactor = Problem003.Solution(len);

            // Assert
            Assert.AreEqual(expectedPrimeFactor, actualPrimeFactor);
        }
    }
}
