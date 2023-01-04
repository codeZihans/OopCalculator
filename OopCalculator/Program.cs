using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine("Welcome to Calculator");
            Console.WriteLine("Operation Available");
            Console.WriteLine(" 1. Add");
            Console.WriteLine(" 2. Substract");
            Console.WriteLine(" 3. Multiply");
            Console.WriteLine(" 4. Divide");
            Console.WriteLine(" 5. Remainder");
            Console.WriteLine(" x. Quit");

            for (int i = 0; i>10; i++)
            {
                Console.Write("Insert your option :");
                string optionstring = Console.ReadLine();
                int optionindex = Convert.ToInt32(optionstring);

                Console.Write("Enter first number: ");
                string firststring = Console.ReadLine();
                int firstindex = Convert.ToInt32(firststring);

                Console.Write("Enter second number");
                string secondstring = Console.ReadLine();
                int secondindex = Convert.ToInt32(secondstring);


                if (optionindex == 1)
                {
                    int sum = calculator.Add(firstindex, secondindex);
                    Console.WriteLine("The sum is : " + sum);
                }
                else if (optionindex == 2)
                {
                    int substract = calculator.Substract(firstindex, secondindex);
                    Console.WriteLine("The substract is : " + substract);
                }
                 else if (optionindex == 3)
                {
                    int multiply = calculator.Multiply(firstindex, secondindex);
                    Console.WriteLine("The result is : " + multiply);
                }
                else if (optionindex == 4)
                {
                    double divide = calculator.Divide(firstindex, secondindex);
                    Console.WriteLine("The result is : " + divide);
                }
                else
                {
                    Console.WriteLine("Please press properly");
                }
            }




        }
    }
}