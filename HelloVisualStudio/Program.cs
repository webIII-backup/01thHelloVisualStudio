using System;

namespace HelloVisualStudio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SayHello());
            Console.ReadLine();
        }

        static string SayHello()
        {
            return "Hello C#";
        }
    }
}
