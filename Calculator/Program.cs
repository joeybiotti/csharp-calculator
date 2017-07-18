using System;

namespace Calculator
{
    class Program
    {
        public class Calculator
        {
            public int sum; 
            public int Add(int num1, int num2)
            {
                int sum = num1 + num2;
                return sum;
            }

            public int diff;
            public int Sub(int num1, int num2)
            {
                int diff = num1 - num2;
                return diff;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
