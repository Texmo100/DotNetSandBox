using DotNetSandBox.Classes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetSandBox.Test.Tests.ScenarioTests
{
    [TestFixture]
    public class Scenario04Test
    {
        [Test]
        public void ShouldReturnAnArrayInAscendingOrder()
        {
            // Arrange
            var arrayTest = new int[] { 2, 1, 3 };

            var scenario04 = new Scenario04(arrayTest);

            // Act
            scenario04.SetAscendentArray();

            var actualResult = scenario04.GetAscendentArray();

            // Assert
            Assert.That(actualResult.GetType().IsArray);
            Assert.That(actualResult, Is.Ordered.Ascending);
        }

        [Test]
        public void ShouldReturnAnArrayInDescendingOrder()
        {
            // Arrange
            var arrayTest = new int[] { 2, 1, 3 };

            var scenario04 = new Scenario04(arrayTest);

            // Act
            scenario04.SetDescendentArray();

            var actualResult = scenario04.GetDescendentArray();

            // Assert
            Assert.That(actualResult.GetType().IsArray);
            Assert.That(actualResult, Is.Ordered.Descending);
        }
    }
}
