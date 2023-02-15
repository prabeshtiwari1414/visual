using System;
namespace Name
{
    class Program
    {
        public static void Main(String [] args){
            Console.WriteLine("Enter Any number to check palindrome");
            int n= Convert.ToInt32(Console.ReadLine());
            int rev=0, rem, num=n;
            while (n!=0){
                rem=n%10;
                rev=rev*10+rem;
                n=n/10;
            }
            if(num==rev){
                Console.WriteLine("Palindrome");
            }
            else{
                Console.WriteLine("Not Palindrome");
            }
        }
    }
}