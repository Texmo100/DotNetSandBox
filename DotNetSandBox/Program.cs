using DotNetSandBox.Classes;
using System;

namespace DotNetSandBox
{
    public class Program
    {
        static void Main(string[] args)
        {
            Scenario02 scenario02 = new Scenario02(new int[3, 2]
            { 
                { 1, 2 },
                { 3, 4 },
                { 5, 6 }
            });

            scenario02.MatrixPrinter();
            scenario02.GreaterNumberInMatrixPrinter();
        }
    }
}
