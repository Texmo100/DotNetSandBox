using DotNetSandBox.Helpers.Writers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetSandBox.Test.Tests.HelperTests
{
    [TestFixture]
    public class IntegerWritersTest
    {
        private readonly IntegerWriters _integerWriters = new IntegerWriters();

        // Good Path
        [Test]
        public void ShouldConvertTheInputPerfectly()
        {
            // Act
            var actualResult = _integerWriters.SelectionWriter("Enter the number please: ", "2");

            // Assert
            Assert.That(actualResult, Is.EqualTo(2));
        }

        // Bad Path
        [Test]
        public void ShouldNotConvertTheInput()
        {
            // Act
            var actualResult = _integerWriters.SelectionWriter("Enter the number please: ", "isaac");

            // Assert
            Assert.That(actualResult, Is.EqualTo(-1));
        }
    }
}
