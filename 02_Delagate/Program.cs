using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Delagate
{
   public class Program
    {
        public delegate void MD(string msg);
        public delegate int MD1(int n1,int n2);
        static void Main(string[] args)
        {

            MD md = Send;
            md("HI");
            md.Invoke("Hi from Invoke");

            MD1 mD1 = Sum;
            Console.WriteLine( mD1.Invoke(12, 4) ); ;
            Console.ReadKey();
        }

        public static void Send(string message)
        {
            Console.WriteLine($"{message} Send!");
        }

        public static int Sum(int number1, int number2) => number1 + number2;
    }


}
