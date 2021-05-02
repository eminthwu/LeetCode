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
            bool isChanged = true;
            var originalLen = nums.Length;

            while (isChanged)
            {
                isChanged = false;

                for (int i = 0; i < originalLen - 1; i++)
                {
                    if (nums[i] == val && i < originalLen - 1)
                    {
                        var curNum = nums[i];

                        for (int j = i; j < nums.Length - 1; j++)
                        {
                            nums[j] = nums[j + 1];
                        }

                        nums[nums.Length - 1] = curNum;
                        isChanged = true;
                        originalLen -= 1;
                        break;
                    }
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                    return i;
            }

            return nums.Length;
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