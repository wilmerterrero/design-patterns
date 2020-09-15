using System;

namespace csharptest
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            if(s1 == s2){
                System.Console.WriteLine("Same instance");
                s1.SayHello("Hello from Singleton 1");
                s2.SayHello("Hello from Singleton 2");
            }
        }
    }
}
