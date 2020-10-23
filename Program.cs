using System;

namespace MoveZerosToEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] unfilteredArr = new int[] { 0, 2, 4, 5, 0, 0, 2, 5, 3, 4 };
            int[] filteredArr = MoveZeros(unfilteredArr);
            foreach(int number in filteredArr)
            {
                Console.Write(number);
            }
        }

        static int[] MoveZeros(int[] nums)
        {
            int[] filteredArr = new int[nums.Length];
            int counter = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] != 0)
                {
                    filteredArr[counter] = nums[i];
                    counter++;
                }
            }
            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] == 0)
                {
                    filteredArr[counter] = nums[i];
                }
            }
            return filteredArr;
        }
    }
}
