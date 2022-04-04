using DotNetSandBox.StrategyPattern;
using System;

namespace DotNetSandBox.Classes
{
    public class Scenario03
    {
        public int StrategyPatternExecution(int firstNumber, int secondNumber, int numberSelector)
        {
            Context context = new Context();
            var result = 0;

            switch (numberSelector)
            {
                case 1:
                    context.SetStrategy(new AddOperation());
                    result = context.ExecuteStrategy(firstNumber, secondNumber);
                    Console.WriteLine($"The strategy selected was Add");
                    break;

                case 2:
                    context.SetStrategy(new SubstractOperation());
                    result = context.ExecuteStrategy(firstNumber, secondNumber);
                    Console.WriteLine($"The strategy selected was Substract");
                    break;

                case 3:
                    context.SetStrategy(new MultiplyOperation());
                    result = context.ExecuteStrategy(firstNumber, secondNumber);
                    Console.WriteLine($"The strategy selected was Multiply");
                    break;
            }

            return result;
        }
    }
}
