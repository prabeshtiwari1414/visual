using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your number to find armstrong");
        int num= Convert.ToInt32(Console.ReadLine());
        int result=0;
        int cube;
        int rem;
        int temp=num;
        
        while(num!=0){
            rem=num%10;
            cube=rem*rem*rem;
            result=result+cube;
            num=num/10;
        }
        if(temp==result){
            Console.WriteLine("Armstrong number");
        }
        else{
            Console.WriteLine("Not a armstrong number");
        }
    }
}