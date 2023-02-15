using System;
namespace Name
{
    class Program
    {
        public static void Main(String []args){
            int[] arr= new int[]{2,4,6,8,16,32};
            Array.Reverse(arr);
            foreach(int newarr in arr){
                Console.Write(""+newarr+" ");
            }
        }
    }
}