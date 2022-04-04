using DotNetSandBox.StrategyPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetSandBox.StrategyPattern
{
    public class AddOperation : IStrategy
    {
        public int Execute(int a, int b)
        {
            return a + b;
        }
    }
}
