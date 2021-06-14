using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Delagate03
{
    class Program
    {
        delegate void Calculator(int a, int b);
        static void Main(string[] args)
        {

            Calculator calculator = (a, b) => { Console.WriteLine(a + b); };
            //Operation(calculator, 12, 4);
            Operation((a, b) => { Console.WriteLine(a / b); }, 12, 4);
            Console.ReadKey();
        }


         static void Operation(Calculator calculator,int number1,int number2)
        {
            calculator.Invoke(number1, number2);
        }

    }

}
