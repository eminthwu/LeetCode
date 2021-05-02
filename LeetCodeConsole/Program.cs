using LeetCodeAlgorithm;
using System;

namespace LeetConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //var nums = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }; var val = 2;
            // var nums = new int[] { }; var val = 0;
            //var nums = new int[] { 1 }; var val = 1;
            var nums = new int[] { 2 }; var val = 3;
            var count = Easy.RemoveElement(nums, val);
            //Easy.RemoveElement(new int[] { 3,2,2,3 }, 3);
        }
    }
}
