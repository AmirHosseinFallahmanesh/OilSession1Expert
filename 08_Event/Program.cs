using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Event
{
    class Program
    {
        static void Main(string[] args)
        {
            HeatMachineConrol heatMachineConrol = new HeatMachineConrol();
            heatMachineConrol.HeatAlert += HeatMachineConrol_HeatAlert; ;
            while (true)
            {
                Random random = new Random();
                heatMachineConrol.InputTemp(random.Next(1000, 4000));
            }

        }

        private static void HeatMachineConrol_HeatAlert(int t)
        {
            Console.WriteLine("*************Danger**********************"+" "+t);
        }
    }
}
