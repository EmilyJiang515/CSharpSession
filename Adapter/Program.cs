using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client(new Adaptor());
            client.PrintResponse();
        }
    }
    // Define other methods, classes and namespaces here
    public class Client
    {
        private ITarget _target;
        public Client(ITarget target)
        {
            _target = target;
        }
        public void PrintResponse()
        {
            Console.WriteLine(_target.GetResponse());
            Console.ReadKey();
        }
    }
    public interface ITarget
    {
        string GetResponse();
    }
}
