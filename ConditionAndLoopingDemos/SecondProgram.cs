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
            int deptno = 0;
            string name = String.Empty;
            string ename;
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            string desig;
            if (!string.IsNullOrEmpty(name))
            {
                string greet = string.Concat(s, name);
                //string greet = s + name;
                Console.WriteLine(greet);
                Console.WriteLine("Enter your Deptno");
                deptno = Convert.ToInt32(Console.ReadLine());
                if (deptno!=0 &&(deptno>=1 || deptno<10))
                {
                    Console.WriteLine("Thanks for the input");

                    for (int i = 0; i < 2; i++)
                    {
                        Console.WriteLine("Enter employee name");
                        ename = Console.ReadLine();
                       Console.WriteLine("Enter his designation");
                        desig = Console.ReadLine();
                        Console.WriteLine("You entered name={0} and designation={1}",ename,desig);
                    }
                }
                else
                Console.WriteLine("Pls enter valid Deptno");

                
            }

            Console.WriteLine("Print Table for a given number");
            Console.WriteLine("Pls enter  a number for the table to be printed");
            int no = Convert.ToInt32(Console.ReadLine());
            //initialization;condition;increment/decrement
            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine("{0}*{1}={2}",no,i,no*i);
            }


            Console.ReadLine();
        }
    }
}
