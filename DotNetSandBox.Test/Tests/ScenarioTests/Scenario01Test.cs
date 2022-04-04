using DotNetSandBox.Classes;
using NUnit.Framework;

namespace DotNetSandBox.Test
{
    [TestFixture]
    public class Scenario01Test
    {
        // Good Path
        [Test]
        public void ShouldPrintTheNumber()
        {
            // Arrange
            Scenario01 scenario01Test = new Scenario01();

            // Act
            var actualResult = scenario01Test.DelegateExecution(3);

            // Assert
            Assert.That(actualResult, Is.EqualTo(4));
        }

        // Bad Path
        [Test]
        public void ShouldNotPrintTheNumber()
        {
            // Arrange
            Scenario01 scenario01Test = new Scenario01();

            // Act
            var actualResult = scenario01Test.DelegateExecution(2);

            // Assert
            Assert.That(actualResult, Is.Not.EqualTo(4));
        }
    }
}