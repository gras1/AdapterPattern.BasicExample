namespace AdapterPattern.BasicExample
{
    public class Adapter2 : ITarget
    {
        private readonly Adaptee2 _adaptee = new Adaptee2();

        public void Request()
        {
            // Possibly do some other work
            //  and then call SpecificRequest
            _adaptee.SpecificRequest2();
        }
    }
}