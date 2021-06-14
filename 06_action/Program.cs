using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_action
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int,int> action1 = (n1, n2) => { Console.WriteLine(n1 + n2); };
            Action<string,string> action2 = (n1, n2) => { Console.WriteLine(n1 + n2); };
            action2.Invoke("amir", "amiri");
            Console.ReadKey();
        }
    }
}
