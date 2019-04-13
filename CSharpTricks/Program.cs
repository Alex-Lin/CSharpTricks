using System;
using System.Dynamic;

namespace CSharpTricks
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic test = new ExpandoObject();
            test.someString = "hello";
            test.someNumber = 1;
            test.someFunction = new Action(() =>
            {
                Console.WriteLine($"param is :" + test.someString);
                Console.WriteLine($"param2 is :" + test.someNumber);
            });

            test.someFunction();
            Console.ReadLine();
        }
    }
}
