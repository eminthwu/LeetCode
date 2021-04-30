using System;
using System.Collections;
using System.Linq;

namespace LeetCodeAlgorithm
{
    public partial class Easy
    {
        //只需要把正確的元素推到最前面就好,不用砍掉他們


        public static int RemoveElement(int[] nums, int val)
        {
            return 0;
        }

        public static int RemoveElement_bad(int[] nums, int val)
        {
            //when use Resize, it create a new object
            
            var hasTarget = false;
            var originalLength = nums.Length;

            Func<int[], int, int> RemoveEle = (numArr, value) =>
            {
                for (int i = 0; i < originalLength; i++)
                {
                    if (numArr[i] == val)
                    {
                        for (int j = i; j < originalLength - 1; j++)
                        {
                            numArr[j] = numArr[j + 1];
                        }

                        originalLength -= 1;
                        hasTarget = true;
                        break;
                    }

                    hasTarget = false;
                }

                nums = numArr;
                return originalLength;
            };

            var count = RemoveEle(nums, val);
            Array.Resize(ref nums, count);

            while (hasTarget)
            {
                count = RemoveEle(nums, val);
                Array.Resize(ref nums, count);
            }

            return nums.Length;
        }
    }
}