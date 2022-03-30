using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetSandBox.Classes
{
    public class Scenario02
    {
        private int[,] _matrix;

        public Scenario02(int[,] matrix)
        {
            _matrix = matrix;
        }

        public void MatrixPrinter()
        {
            for (int i = 0; i < _matrix.GetLength(0); i++)
            {
                for (int j = 0; j < _matrix.GetLength(1); j++)
                {
                    Console.Write($" {_matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public int GreaterNumberInMatrix()
        {
            int greaterNumber = int.MinValue;

            for (int i = 0; i < _matrix.GetLength(0); i++)
            {
                for (int j = 0; j < _matrix.GetLength(1); j++)
                {
                    if(_matrix[i,j] > greaterNumber) greaterNumber = _matrix[i,j];
                }
            }

            return greaterNumber;
        }

        public void GreaterNumberInMatrixPrinter()
        {
            Console.WriteLine($"This is the greater number in the matrix: {GreaterNumberInMatrix()}");
        }
    }
}
