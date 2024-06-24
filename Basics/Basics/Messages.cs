using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    static class Messages // napisali smo static kako bi smo mogli koristiti klasu u Program.cs
    {
        public static void Hello() // napisali smo static kako bi smo mogli koristiti metodu u Program.cs
        {                        // također smo napisali public kako bi ova metoda bila visible u Program.cs bilo
            Console.WriteLine("Hello! Welcome to the program");
        }
        public static void Waiting() // napisali smo static kako bi smo mogli koristiti metodu u Program.cs
        {                        // također smo napisali public kako bi ova metoda bila visible u Program.cs bilo
            Console.WriteLine("I am waiting for something");
        }
        public static void Bye() // napisali smo static kako bi smo mogli koristiti metodu u Program.cs
        {                        // također smo napisali public kako bi ova metoda bila visible u Program.cs bilo
            Console.WriteLine("Bye! Thanks for visiting");
        }
    }
}
