
namespace AdapterPattern
{
    public class Adaptor : ITarget
    {
        private Adaptee _adaptee = new Adaptee();

        public string GetResponse()
        {
            return _adaptee.GetCount().ToString();
        }
    }
}
