using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_Pyramid31Patterns.Pyramid31Pattterns
{
   public  class Pyramid1
    {
        public static void MyPyramid1Display()
        {
            Console.WriteLine(" Enter the Number of the Rows ");
            int rows = int.Parse(Console.ReadLine());

            for(int i=0; i<=rows; i++)
            {
                for (int j = rows; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }
        
    }
}
