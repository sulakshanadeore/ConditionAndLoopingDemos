using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionAndLoopingDemos
{
    class PatternLoopDemo
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <=5; i++)
            //{
            //    for (int j = 1; j <=i; j++)
            //    {
            //        Console.Write(j + "\t");
            //    }
            //    Console.WriteLine();
            //}


            //int i = 1;
            //while (i<=5)
            //{
            //    for (int j = 1; j <=i; j++)
            //    {
            //        Console.Write(i + " ");
            //    }
            //    Console.WriteLine();
            //    i++;
            //}


            for (int i = 1; i <=4; i++)
            {
                if (i==3)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("------------------");

            int cnt = 1;
            while (cnt<=5)
            {
                Console.WriteLine(cnt);
                cnt++;
                if (cnt==4)
                {
                    break;
                }
            }

            Console.WriteLine("------------------");
            int sum = 0;
            for (int a = 1; a <=3; a++)
            {
                for (int b = 1; b <=3; b++)
                {
                    if (a==2)
                    {
                        break;
                    }
                    sum = a + b;
                    Console.WriteLine("a={0} b={1} {0}+{1}={2}",a,b,sum);
                }
            }
            Console.WriteLine("----------------");
            Console.WriteLine("enter a char to find whether vovel or not");
            char input = Convert.ToChar(Console.ReadLine());

            switch (input)
            {
                case 'a':
                    Console.WriteLine("Yes its vovel");
                break;
                case 'e':
                    Console.WriteLine("Yes its vovel");
                    break;
                case 'i':
                    Console.WriteLine("Yes its vovel");
                    break;
                case 'o':
                    Console.WriteLine("Yes its vovel");
                    break;
                case 'u':

                    break;
                default:
                    Console.WriteLine("Not a vovel");
                    break;
            }
            Console.Read();

        }
    }
}
