using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramOne
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[96]; 
            
            
            Random rand = new Random();

            int i = 0;
            

            while (i < numbers.Length)
            {

                int random = rand.Next(0, 100);

                if (!numbers.Contains(random))
                {
                    
                    Console.Write("Поиск: ");                  
                    numbers[i] = random;
                    Console.WriteLine(i + " " + $"{ numbers[i]}");
                    i++;
                }
               

            }

          

            Console.ReadKey();
        }

       

    }
}
