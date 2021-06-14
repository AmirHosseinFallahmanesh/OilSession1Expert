using System;

namespace _0_InterfaceDemo
{
    internal class GmailMailSender : ISender
    {
        public bool SendStatus { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Send(string message, string destAddress, string username, string password)
        {
           
        }
    }
}
