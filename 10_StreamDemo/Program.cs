using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_StreamDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // StreamWriter writer = new StreamWriter(@"E:\test\a.txt",true);
            StreamReader reader = new StreamReader("a.txt");
            //string a= reader.ReadToEnd();


            List<string> data = new List<string>();
            while (!reader.EndOfStream)
            {
                data.Add(reader.ReadLine());

            }
           
         
 



     
            Console.WriteLine("Done");
            Console.ReadKey();

        }

        private static void Write()
        {
            StreamWriter writer = new StreamWriter("b.jpg", true);
            writer.WriteLine("item40");
            writer.WriteLine("item50");
            writer.Flush();
            writer.Close();
        }
    }
}
