using System;

namespace _08_Event
{
    public class HeatMachineConrol
    {
        public delegate void Alert(int t);
        public event Alert HeatAlert;


        public void InputTemp(int T)
        {
            if (T>2000)
            {
                HeatAlert(T);
            }
            else
            {
                Console.WriteLine("Normal");
            }
            
        }

    }
}
