using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionAndLoopingDemos
{
    class WhileExample
    {
        static void Main(string[] args)
        {
            int oloop = 0, iloop = 0;
            for (int k = 1; k <=5; k++)
            {
                oloop++;
                for (int g = 1; g <=5; g++)
                {
                    iloop++;
                }

            }
            Console.WriteLine("Outer= " + oloop);
            Console.WriteLine("Inner=" + iloop);
            Console.WriteLine("-----------------------------");


            



            int n = 10, sum = 0;
            int i = 0;
            while (i <= n)
            {
                sum += i;
                i++;

            }
            Console.WriteLine(sum);
            Console.WriteLine("----------------");
            int j = 1, num = 10, product=1;
            do
            {
                product = num * j;
                Console.WriteLine(product);
                j++;
            } while (j<=10);
            Console.Read();


            
        }
    }
}
