using LeetCodeAlgorithm;
using System;

namespace LeetConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var nums = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
            var count = Easy.RemoveElement(nums, 2);
            //Easy.RemoveElement(new int[] { 3,2,2,3 }, 3);
        }
    }
}
