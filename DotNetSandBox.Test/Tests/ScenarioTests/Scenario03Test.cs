using DotNetSandBox.Classes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetSandBox.Test.Tests.ScenarioTests
{
    [TestFixture]
    public class Scenario03Test
    {
        [Test]
        [TestCase(1, ExpectedResult = 7)]
        [TestCase(2, ExpectedResult = -3)]
        [TestCase(3, ExpectedResult = 10)]
        public int ShouldDoTheCorrectOperation(int opreationSelector)
        {
            // Arrange
            Scenario03 scenario03 = new Scenario03();

            // Act
            var actualResult = scenario03.StrategyPatternExecution(2, 5, opreationSelector);

            // Assert
            return actualResult;
        }
    }
}
