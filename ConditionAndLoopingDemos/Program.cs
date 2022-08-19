using System;


namespace ConditionAndLoopingDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a comment.



            #region If-ElseRegion
            int i = 10;
            Console.WriteLine("Enter the value for i");
            i = Convert.ToInt32(Console.ReadLine());
            if (i != 0)
            {
                if (i > 0 && i < 10)
                {
                    Console.WriteLine("I is greater than 0 and smaller than 10");
                }
                else if (i == 10)
                {
                    Console.WriteLine("I is equal to 10");
                }
                else
                {
                    Console.WriteLine("None from the options");
                }

            }
            else
            {
                Console.WriteLine("I is not equal to 10");
            } 
            #endregion
        }
    }
}
