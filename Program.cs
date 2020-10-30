//This is a C# program that greets the user and displays their age
using System;

namespace program1.cs
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            SayHi("Gumie", 27);
            SayHi("Irene", 64);
            SayHi("Brian", 32);

            Console.ReadLine();
        }

        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello "+ name + " you are " + age + " years old");
        }
    }
}