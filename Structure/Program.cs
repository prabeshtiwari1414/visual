using System;
namespace Name
{
    public struct Person
    {
        public string name;
        public int age;
        public int weight;

    }
    class Student{
        static void Main(String [] args){
            Person p1;
            p1.name="Prabesh Tiwari";
            p1.age=18;
            p1.weight=55;
            Person p2;
            p2=p1;
            Console.WriteLine("Values stored in p1");
            Console.WriteLine("Name:"+p1.name);
            Console.WriteLine("Age:"+p1.age);
            Console.WriteLine("Weight:"+p1.weight);
            Console.WriteLine();
            Console.WriteLine("Value stored in p2");
            Console.WriteLine("Name:"+p2.name);
            Console.WriteLine("Age:"+p2.age);
            Console.WriteLine("Weight:"+p2.weight);            
        }
    }
}