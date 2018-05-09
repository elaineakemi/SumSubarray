using System;
using System.Linq;

namespace SumSubarray
{
    public class SplitArray
    {
        /// <summary>
        /// Check if array can be splited in two subarrays which sum are equal
        /// </summary>
        /// <param name="arr">Array of int</param>
        /// <returns>If sum of subarrays are equal</returns>
        public bool isSumEqual(int[] arr)
        {
            if (arr.Count() == 0)
            {
                return true;
            }

            int left = 0; int indexRight = arr.Count() - 1;
            int right = 0; int indexLeft = 0;

            for (int i = 0; i < arr.Count() - 1; i++)
            {
                if (indexLeft == indexRight)
                {
                    break;
                }
                else
                {
                    if (right > left)
                    {
                        indexLeft++;
                        left += arr[indexLeft];
                    }
                    else if (right < left)
                    {
                        indexRight--;
                        right += arr[indexRight];
                    }
                    else
                    {
                        left += arr[i];
                        right += arr[indexRight];
                    }
                }
            }

            return left == right;
        }
    }
}
