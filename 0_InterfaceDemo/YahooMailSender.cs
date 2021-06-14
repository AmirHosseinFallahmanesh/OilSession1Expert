using System;

namespace _0_InterfaceDemo
{
    class YahooMailSender : ISender
    {
        public bool SendStatus { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Send(string message, string destAddress, string username, string password)
        {
            throw new NotImplementedException();
        }
    }

   
}
