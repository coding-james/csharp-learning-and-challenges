using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Codewars.kyu6
{
    public class EqualSidesOfAnArray
    {
        public static int FindEvenIndex(int[] arr)
        {
            // Console.WriteLine("[{0}]", string.Join(", ", arr)); // Write arr to one line
            int leftSum = 0;
            int rightSum = 0;

            if (arr == null || arr.Length == 0) return 0;

            // Sum All & if index 1 to end == 0
            foreach (int num in arr)
            {
                leftSum += num;
            }

            if (leftSum == 0 || leftSum - arr[0] == 0) return 0;
            if (leftSum - arr[arr.Length - 1] == 0) return arr.Length - 1;
            leftSum = 0;

            // Looping Sum Left & Right
            for (int i = 1; i < arr.Length - 1; i++)
            {
                // Sum left side
                for (int leftIndex = 0; leftIndex < i; leftIndex++)
                {
                    leftSum += arr[leftIndex];
                }

                // Sum right side
                for (int rightIndex = i + 1; rightIndex < arr.Length; rightIndex++)
                    rightSum += arr[rightIndex];

                if (leftSum == rightSum) return i;
                leftSum = 0;
                rightSum = 0;
            }

            return -1;
        }
    }
}
