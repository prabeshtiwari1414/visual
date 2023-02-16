using System;

class Program
{
    static void Main(string[] args)
    {
        // Declare and initialize an integer array of size 5
        int[] nums = { 10, 20, 30, 40, 50 };

        // Access and print each element in the array
        for (int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine("Element at index {0} is {1}", i, nums[i]);
        }

        // Modify an element in the array
        nums[2] = 35;

        // Access and print each element in the modified array
        for (int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine("Element at index {0} is {1}", i, nums[i]);
        }
    }
}
