using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopCalculator
{
    public class Calculator
    {
        public int Add(int first, int second)
        {
            int sum = first + second;
            return sum;
        }
        public int Substract(int first, int second)
        {
            int substract = first - second;
            return substract;
        }
        public int Multiply(int first, int second)
        {
            int multiply = first * second;
            return multiply;
        }
        public double Divide(int first, int second)
        {
            double divide =  (double)first / second;
            return divide;
        }
    }
}
