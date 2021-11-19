using System;

namespace VariablesCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C#");
            Console.WriteLine();
            var numberOfCupsOfCoffee = 5;
            var fullName = "JonathonChilds";
            var today = DateTime.Now.ToString("M/d/yyyy");
            Console.WriteLine("{0} {1} {2}", numberOfCupsOfCoffee, fullName, today);
            Console.WriteLine();
            Console.WriteLine("Hey friend, what's your name?");
            Console.Write("");
            Console.WriteLine();
            var name = Console.ReadLine();
            if (name == "Alice")
            {
                Console.WriteLine();

                Console.WriteLine("In that direction, <-- Alice, lives a Hatter, and in that --> direction lives a March Hare. Visit either you like: they’re both mad.");
            }
            else if (name == "alice")
            {
                Console.WriteLine("In that direction, <-- Alice, lives a Hatter, and in that --> direction lives a March Hare. Visit either you like: they’re both mad.");
            }
            else
            {
                Console.WriteLine($"It is a pleasure to meet you, {name}");
            }
            Console.WriteLine();
            Console.WriteLine($"Please input a number, {name}.");
            var firstNumberAsString = Console.ReadLine();
            Console.WriteLine("Please input another number.");
            var secondNumberAsString = Console.ReadLine();
            double firstOperand = double.Parse(firstNumberAsString);
            double secondOperand = double.Parse(secondNumberAsString);
            Console.WriteLine();
            double sum = firstOperand + secondOperand;
            double difference = firstOperand - secondOperand;
            double product = firstOperand * secondOperand;
            double quotient = firstOperand / secondOperand;
            double remainder = firstOperand % secondOperand;
            Console.WriteLine($"Adding {firstNumberAsString} to {secondNumberAsString} = {sum}.");
            Console.WriteLine();
            Console.WriteLine($"Subtracting {firstNumberAsString} from {secondNumberAsString} = {difference}.");
            Console.WriteLine();
            Console.WriteLine($"Multiplying {firstNumberAsString} by {secondNumberAsString} = {product}.");
            Console.WriteLine();
            Console.WriteLine($"Dividing {firstNumberAsString} by {secondNumberAsString} = {quotient}.");
            Console.WriteLine();
            Console.WriteLine($"The remainder when dividing {firstNumberAsString} by {secondNumberAsString} = {remainder}.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Goobye for now, {name}.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}




