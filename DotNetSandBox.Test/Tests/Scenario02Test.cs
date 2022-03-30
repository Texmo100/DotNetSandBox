using DotNetSandBox.Classes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetSandBox.Test.Tests
{
    [TestFixture]
    public class Scenario02Test
    {
        private Scenario02 _scenario02Test;

        [SetUp]
        public void CreateTestScenario()
        {
            _scenario02Test = new Scenario02(new int[3, 2]
            {
                { 1, 2 },
                { 3, 4 },
                { 5, 6 }
            });
        }

        [Test]
        [TestCase(ExpectedResult = 6)]
        public int ShouldGetTheGreaterNumberInMatrix()
        {
            // Act
            var actualValue = _scenario02Test.GreaterNumberInMatrix();

            // Assert
            return actualValue;
        }

        // Bad Path
        [Test]
        public void ShouldNotGetTheGreaterNumberInMatrix()
        {
            // Act
            var actualValue = _scenario02Test.GreaterNumberInMatrix();

            // Assert
            Assert.That(actualValue, Is.Not.EqualTo(10));
        }
    }
}
