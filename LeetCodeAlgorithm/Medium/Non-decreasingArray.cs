using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeAlgorithm.Medium
{
    public class Non_decreasingArray
    {
        public static bool CheckPossibility(int[] nums)
        {
            int index = 0;

            // case 1, 數列內有兩組大於

            var count = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                var curNum = nums[i];
                var nextNum = nums[i + 1];

                if (curNum > nextNum)
                {
                    index = i + 1;
                    count++;
                }

                if (count > 1)
                    return false;
            }

            if (count == 0)
                return true;

            //case 2 有一組大於                     

            //如果是第一個元素大於,就一定可以調整
            //如果是倒數第二個元素大於,就一定可以調整
            if (index - 1 == 0 || index + 1 == nums.Length)
                return true;

            //先看自己有沒有調整的空間   

            var left = index-1 < 0 ? 0 : nums[index - 1];
            var middle = nums[index];
            var right = index == nums.Length - 1 ? 0 : nums[index + 1];
            var result1 = Check(left, middle, right);

            if (result1)
                return true;

            //再看前一位能不能調整
            index--;
            left = index == 0 ? 0 : nums[index - 1];
            middle = nums[index];
            right = index == nums.Length - 1 ? 0 : nums[index + 1];
            var result2 = Check(left, middle, right);

            if (result2)
                return true;

            return false;

            static bool Check(int left, int middle, int right) => left - middle <= right - middle;

        }
    }
}
