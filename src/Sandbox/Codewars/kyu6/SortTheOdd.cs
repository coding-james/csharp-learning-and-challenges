using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Codewars.kyu6
{
    // CODEWARS: Sort the odd
    public class SortTheOdd
    {
        public static int[] SortArray(int[] array)
        {
            List<int> odd = new List<int>();
            foreach (int num in array)
            {
                if (num % 2 != 0)
                {
                    odd.Add(num);
                }
            }

            odd.Sort();
            int oddIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    array[i] = odd[oddIndex];
                    oddIndex++;
                }
            }

            return array;
        }
    }
}
