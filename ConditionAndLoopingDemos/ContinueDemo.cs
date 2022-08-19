using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionAndLoopingDemos
{
    class ContinueDemo
    {
        static void Main(string[] args)
        {
            //int i = 0;
            //while (i<5)
            //{
            //    i++;
            //    if (i==2)
            //    {
            //        Console.WriteLine(i);
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}


            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j <=5; j++)
                {
                    if (j==2)
                    {
                        Console.WriteLine("i= " + i + " j= " + j);
                        continue;
                    }
                    
                    Console.WriteLine("i= " + i + " j= " + j);
                    
                }
                Console.WriteLine();
            }



            Console.ReadKey();
        }
    }
}
