using System;

namespace AdapterPattern.BasicExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the first adapter and place a request
            ITarget target = new Adapter1();
            target.Request();

            // Create the second adapter and place a request
            target = new Adapter2();
            target.Request();

            // Wait for user
            Console.ReadKey();
        }
    }
}