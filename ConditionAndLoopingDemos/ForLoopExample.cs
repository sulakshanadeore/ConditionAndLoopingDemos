using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionAndLoopingDemos
{
    class ForLoopExample
    {
        /// <summary>
        /// compute sum of first n natural numbers
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int n = 10,sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
            Console.WriteLine("----------------------------");
            for (int i = 0,j=0; i+j<=5; i++,j++)
            {
                Console.WriteLine("i={0} and j={1}",i,j);
            }
            Console.WriteLine("------------");
            int k = 1;
            for (; k <=5;)
            {
                Console.WriteLine(k);
                k++;
            }

            //for (int i = 1; i >0; i++)
            //{
            //    Console.WriteLine(i);
            //}


            Console.Read();
        }
    }
}
