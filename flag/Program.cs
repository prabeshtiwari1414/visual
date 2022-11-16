using System;
namespace Name
{
    class Program
    {
        public static void Main(String [] args){
            for(int i=0; i<=1; i++){
                for(int j=0; j<=5; j++){
                    for(int k=0; k<=j; k++){
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                }
            }
        }
    }
}