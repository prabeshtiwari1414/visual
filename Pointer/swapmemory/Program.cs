using System;
namespace Name
{
    class Program
    {
        public unsafe void Swap(int*p,int*q){
            int temp=*q;
            *p=*q;
            *q=temp;
        }
        public unsafe static void Main(String [] args){
            Program p = new Program();
            int var1=10;
            int var2=20;
            int* x=&var1;
            int* y=&var2;
            Console.WriteLine("Before Swap:var1={0},var2={1}",var1,var2);
            p.Swap(x,y);
            Console.WriteLine("After Swap: var1:{0},var2:{1)",var1,var2);
           
        }
    }
}