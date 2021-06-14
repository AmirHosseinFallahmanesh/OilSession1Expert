using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Split0
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "12344asda-dsadasd-sada,amir,amrii,18";
          List<string>  result=text.Split(',').ToList();
        }
    }
}
