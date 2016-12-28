using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var textBuilder = new HelloWorldTextBuilder();

            var text = textBuilder.CreateHelloWorldText();

            Console.WriteLine(text);            
        }
    }
}
