using System;

namespace CSharpQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the C# Quiz!\n");

            int score = 0;

            // Question 1
            Console.WriteLine("Question 1: What does 'C#' stand for?");
            Console.WriteLine("A. C Sharp");
            Console.WriteLine("B. C Hash");
            Console.WriteLine("C. C Number");
            Console.WriteLine("D. C Octothorpe");

            string answer1 = Console.ReadLine();

            if (answer1.ToLower() == "a")
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect.");
            }

            Console.WriteLine();

            // Question 2
            Console.WriteLine("Question 2: Which of the following is not a data type in C#?");
            Console.WriteLine("A. int");
            Console.WriteLine("B. double");
            Console.WriteLine("C. string");
            Console.WriteLine("D. boolean");
            Console.WriteLine("E. char");

            string answer2 = Console.ReadLine();

            if (answer2.ToLower() == "e")
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect.");
            }

            Console.WriteLine();

            // Question 3
            Console.WriteLine("Question 3: What is the syntax for declaring a variable in C#?");
            Console.WriteLine("A. variableName variableType = variableValue;");
            Console.WriteLine("B. variableType variableName = variableValue;");
            Console.WriteLine("C. variableType = variableValue variableName;");
            Console.WriteLine("D. variableName = variableType(variableValue);");

            string answer3 = Console.ReadLine();

            if (answer3.ToLower() == "b")
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect.");
            }

            Console.WriteLine();

            // Print final score
            Console.WriteLine($"Your final score is {score} out of 3.");

            Console.ReadLine();
        }
    }
}
