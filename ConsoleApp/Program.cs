using System;
using ClassLibraryApp;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ClassLibraryApp.Class1 simpleClass1 = new Class1();
            ClassLibraryApp.Class2 simpleClass2 = new Class2();
            var s1 = simpleClass1.spitOut();
            var s2 = simpleClass2.spitOut();

            Console.WriteLine(s1);
            Console.WriteLine(s2);

        }
    }
}
