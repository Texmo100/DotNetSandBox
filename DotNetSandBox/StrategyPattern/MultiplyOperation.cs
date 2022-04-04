using DotNetSandBox.StrategyPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetSandBox.StrategyPattern
{
    public class MultiplyOperation : IStrategy
    {
        public int Execute(int a, int b)
        {
            return a * b;
        }
    }
}
