using System;

namespace AdapterPattern.BasicExample
{
    public class Adaptee1
    {
        public void SpecificRequest1()
        {
            Console.WriteLine("Called SpecificRequest1()");
        }
    }
}