using DotNetSandBox.Classes;
using DotNetSandBox.Helpers.Writers;
using DotNetSandBox.StrategyPattern;
using System;

namespace DotNetSandBox
{
    public class Program
    {

        static readonly IntegerWriters _integerWriters = new IntegerWriters();

        public static void Main(string[] args)
        {
            Scenario04Execution();
        }

        public static void Scenario04Execution()
        {
            int[] arrayTest = new int[] { 2, 1, 3 };
            int[] arrayTest2 = new int[] { 90, 1, 11, 30, 120 };

            var asDesArray = new Scenario04(arrayTest2);
            asDesArray.SetAscendentArray();
            asDesArray.SetDescendentArray();

            ArrayPrinter(asDesArray.GetAscendentArray());
            Console.WriteLine();
            ArrayPrinter(asDesArray.GetDescendentArray());
        }

        public static void ArrayPrinter(int[] array)
        {
            foreach (int element in array)
            {
                Console.WriteLine(element);
            }
        }

        public static void Scenario03Execution()
        {
            Scenario03 scenario03 = new Scenario03();

            var firstNumber = _integerWriters.IntWriter("Enter the first number please: ");
            var secondNumber = _integerWriters.IntWriter("Enter the second number please: ");
            StrategyMenu();
            var numberSelector = _integerWriters.SelectionWriter("Enter your option please");

            scenario03.StrategyPatternExecution(firstNumber, secondNumber, numberSelector);
        }

        public static void StrategyMenu()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("1 : Add Operation");
            Console.WriteLine("2 : Substract Operation");
            Console.WriteLine("3 : Mutiply Operation");
            Console.WriteLine("-----------------------");
        }
    }
}
