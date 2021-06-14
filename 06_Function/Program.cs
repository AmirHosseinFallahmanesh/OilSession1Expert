using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int> f1 = () => { return 10; };
            Func<string> f2 = () => { Console.WriteLine(); ; return ""; };
            Func<int, int> f3 = (a) => { return a + 5; };
            Func<int, int, string> f4 = (a, b) => { return (a + b).ToString(); };
            f4.Invoke(12, 4);

        }
    }
}
