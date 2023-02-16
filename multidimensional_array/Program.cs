using System;

class Program
{
    static void Main(string[] args)
    {
        // Declare and initialize a 2D integer array of size 3x3
        int[,] nums = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

        // Access and print each element in the array
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine("Element at [{0},{1}] is {2}", i, j, nums[i, j]);
            }
        }

        // Modify an element in the array
        nums[1, 2] = 10;

        // Access and print each element in the modified array
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine("Element at [{0},{1}] is {2}", i, j, nums[i, j]);
            }
        }
    }
}
