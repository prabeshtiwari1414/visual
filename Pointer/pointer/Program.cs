using System;
namespace Name
{
    class Program
    {
      unsafe void Print(int* p){
        Console.WriteLine((int)p);
      }
      unsafe static void Main(String [] args){
        Program p1 = new Program();
        int i=42;
        int* p=&i;
        p1.Print(p);
      }
    }
}