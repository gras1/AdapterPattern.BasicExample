namespace AdapterPattern.BasicExample
{
    public class Adapter1 : ITarget
    {
        private readonly Adaptee1 _adaptee = new Adaptee1();

        public void Request()
        {
            // Possibly do some other work
            //  and then call SpecificRequest1
            _adaptee.SpecificRequest1();
        }
    }
}