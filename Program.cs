using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
           // Declaring variables
            int min = 147483647, max = 0, num = 0;
            int quant = 0, x = 0;
           

            //Requesting data from the user
            Console.Write(" Enter the number of numbers you want to process: ");
            quant = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.Write(" Enter a number between 0 and 147483647: ");
                num = Convert.ToInt32(Console.ReadLine());

               if(num >= 0 && num <= 147483647)
                {
                    if(num <= min)
                    {
                        min = num; 
                    }
                    if(num >= max)
                    {
                        max = num;
                    }
                }
                                              
               x++;
            }
            while (x < quant);

             
            //Showing result
            Console.WriteLine(" The bigest number of the list is: {0}", max);

            Console.WriteLine(" The smallest number of the list is: {0}", min);

            Console.ReadKey();


        }
    }

}

