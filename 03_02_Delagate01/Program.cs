using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_02_Delagate01
{
    class Program
    {
        public delegate void  Calculator(int n1, int n2);
        static void Main(string[] args)
        {
            Calculator calculator = Sum;
            calculator += Divide;
            calculator += Mlp;
             calculator.Invoke(12, 4);
            Console.Read();
        }

        public static void Sum(int number1, int number2) => Console.WriteLine( number2 + number1 ); 
        public static void Divide(int number1, int number2) => Console.WriteLine(number1 / number2);
        public static void Mlp(int number1, int number2) => Console.WriteLine(number2 * number1);

    }
}
