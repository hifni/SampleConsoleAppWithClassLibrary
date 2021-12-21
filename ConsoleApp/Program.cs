using System;
using ClassLibraryApp;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ClassLibraryApp.Class1 simpleClass = new Class1();
            var s = simpleClass.CanAccess();

            Console.WriteLine(s);
        
        }
    }
}
