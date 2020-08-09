using System;

namespace PracticeProblem5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter some text and I will capitalize your text on your behalf:");
            string userInput = Console.ReadLine();
            string angryUser = userInput.ToUpper();
            Console.WriteLine(angryUser);
            Console.ReadLine();
        }
    }
}
