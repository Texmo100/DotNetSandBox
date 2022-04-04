using DotNetSandBox.StrategyPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetSandBox.StrategyPattern
{
    public class Context
    {
        private IStrategy strategy;

        public void SetStrategy(IStrategy strategy)
        {
           this.strategy = strategy;
        }

        public int ExecuteStrategy(int a, int b)
        {
            return strategy.Execute(a, b);
        }
    }
}
