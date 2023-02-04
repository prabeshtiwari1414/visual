using System;
namespace Name
{
    class Program
    {
        public static void Main(String [] args){
            Console.WriteLine("Enter any 2 number");
            int a=Convert.ToInt32(Console.ReadLine());
            int b=Convert.ToInt32(Console.ReadLine());
            if(a<b){
                Console.WriteLine(b+" is greater");
            }
            else if (b<a){
                Console.WriteLine(a+" is greater");
            }
            else{
                Console.WriteLine(a+"="+b+"Both are equal");
            }
        }
    }
}