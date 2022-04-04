using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetSandBox.StrategyPattern.Interface
{
    public interface IStrategy
    {
        int Execute(int a, int b);
    }
}
