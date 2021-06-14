using System;

namespace _0_InterfaceDemo
{
    public class MicrosoftMailSender : ISender
    {
        public bool SendStatus { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Send(string message, string destAddress, string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
