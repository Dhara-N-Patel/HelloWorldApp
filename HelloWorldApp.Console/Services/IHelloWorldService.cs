using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorldApp.Console.Services
{
    public interface IHelloWorldService
    {
        string getGreetings(bool fromAPI);
    }
}
