using System;
namespace Name
{
    class Program
    {
        public static void Main(String [] args){
            int n=3443, rev=0, rem, num=n;
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