using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetSandBox.Classes
{
    public class Scenario04
    {
        private int[] _Array;
        private int[] _AscendentArray;
        private int[] _DescendentArray;

        public Scenario04(int[] array)
        {
            _Array = array;
        }

        public int[] GetAscendentArray()
        {
            return _AscendentArray;
        }

        public int[] GetDescendentArray()
        {
            return _DescendentArray;
        }

        public void SetAscendentArray()
        {
            // original => 2, 1, 3
            // result => 1, 2, 3
            int auxValue = 0;
            int[] array = (int[])_Array.Clone();

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        auxValue = array[i];
                        array[i] = array[j];
                        array[j] = auxValue;
                    }
                }
            }

            _AscendentArray = array;
        }

        public void SetDescendentArray()
        {
            // original => 2, 1, 3
            // result => 3, 2, 1
            int auxValue = 0;
            int[] array = (int[])_Array.Clone();

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] > array[i])
                    {
                        auxValue = array[i];
                        array[i] = array[j];
                        array[j] = auxValue;
                    }
                }
            }

            _DescendentArray = array;
        }
    }
}
