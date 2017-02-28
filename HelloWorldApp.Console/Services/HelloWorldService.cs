using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorldApp.Console.Services
{
    public class HelloWorldService : IHelloWorldService
    {
        public string getGreetings(bool fromAPI)
        {
            string helloWorld = "------Hello World!!------";

            System.Console.WriteLine(helloWorld);

            if (!fromAPI)
            {
                System.Console.ReadKey();
            }
            return helloWorld;
        }
    }
}

