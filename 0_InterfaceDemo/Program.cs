using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            ISender sender = new GmailMailSender();
            sender = new YahooMailSender();
            sender.Send("", "", "", "");


        }
    }
}
