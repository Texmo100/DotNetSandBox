using DotNetSandBox.Helpers.Extensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetSandBox.Test.Tests.HelperTests
{
    [TestFixture]
    public class ExtensionsTest
    {
        // Good Path
        [Test]
        public void ShouldIndicatesThatTheInputIsANumber()
        {
            // Arrnage
            var testInput = "1";

            // Act
            var actualResult = testInput.IsValidNumber();

            // Assert
            Assert.That(actualResult, Is.True);
        }

        // Bad Path
        [Test]
        public void ShouldIndicatesThatTheInputIsNotANumber()
        {
            // Arrange
            var testInput = "isaac";

            // Act
            var actualResult = testInput.IsValidNumber();

            // Assert
            Assert.That(actualResult, Is.False);
        }
    }
}
