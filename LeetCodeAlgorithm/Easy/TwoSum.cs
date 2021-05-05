using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeAlgorithm
{
    public partial class Easy
    {

        /*
         * 2, 7, 11, 15 target 9
         * 用target減去每個元素,所得到的差及代表這個元素還需要哪個數才能組合成target
         * 將元素存入雜湊表的索引,陣列索引則存入值
         * 在遍歷的過程中,持續做target減去元素,如果發現差已經存在於雜湊表的索引中,及代表目前的元素跟曾經遍歷過的元素可以組合成目標
         * 即返還目前的元素索引及成對的元素索引
        */
        public static int[] TwoSum(int[] nums, int target)
        {
            var map = new Hashtable();
            
            for (int i = 0; i < nums.Length; i++)
            {
                int difference = target - nums[i];
                if (map[difference] != null)
                {
                    return new int[] { (int)map[difference], i };
                }
                map[nums[i]] = i;
            }

            return null;
        }
    }
}
