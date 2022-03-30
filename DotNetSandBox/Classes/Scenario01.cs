using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetSandBox.Classes
{
    public class Scenario01
    {
        public delegate int Print(int value);

        public int PlusNumber(int num)
        {
            return num + 1;
        }

        public int DelegateExecution(int number)
        {
            Print numbersOperation = PlusNumber;
            return numbersOperation(number);
        }
    }
}
