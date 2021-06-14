namespace _0_InterfaceDemo
{
    public interface ISender
    {
        void Send(string message, string destAddress, string username, string password);

         bool SendStatus { get; set; }
    }
}
