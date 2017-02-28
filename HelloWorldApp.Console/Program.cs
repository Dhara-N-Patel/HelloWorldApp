using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelloWorldApp.Console.Services;

namespace HelloWorldApp.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var helloWorldService = new HelloWorldService();
            var fromAPI = false;

            helloWorldService.getGreetings(fromAPI);
        }
    }
}
