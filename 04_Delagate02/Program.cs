using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Delagate02
{
    class Program
    {
        delegate void voidNoParamDelegate();
        delegate void voidParamDelegate(int a,string b);
        delegate int returnNoParamDelegate();
        delegate int returnParamDelegate(int n1,int n2);
        static void Main(string[] args)
        {

            voidNoParamDelegate vnpd = new voidNoParamDelegate(() => 
            {
                Console.WriteLine("Hello World");
            });

            voidNoParamDelegate vnpdf = () =>
            {
                Console.WriteLine("Hello World");
            };



            // vnpd.Invoke();
            voidParamDelegate vpd = new voidParamDelegate((number1, text1) =>
              {
                  Console.WriteLine(number1);
                  Console.WriteLine(text1);
              });


            voidParamDelegate vpdf = (number1, text1) =>
            {
                Console.WriteLine(number1);
                Console.WriteLine(text1);
            };



            returnNoParamDelegate rnpd = new returnNoParamDelegate(() =>
              {
                  Console.WriteLine("-------");
                  return 12;

              });

            returnNoParamDelegate rnpdf = () =>
            {
                Console.WriteLine("-------");
                return 12;

            };




            returnParamDelegate rpd = new returnParamDelegate((n1, n2) =>
              {
                  return n1 + n2;
              });


            returnParamDelegate rpdf = (n1, n2) =>
            {
                return n1 + n2;
            };

            Console.ReadLine();
        }
    }
}
