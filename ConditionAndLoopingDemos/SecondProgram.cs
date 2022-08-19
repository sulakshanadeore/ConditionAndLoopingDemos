using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionAndLoopingDemos
{
    class SecondProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is my second main");
            string s = "Hello ";
            string name = String.Empty;
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            if (!string.IsNullOrEmpty(name))
            {
                string greet = string.Concat(s, name);
                //string greet = s + name;
                Console.WriteLine(greet);
            }

            Console.ReadLine();
        }
    }
}
