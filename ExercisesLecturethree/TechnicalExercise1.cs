using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesLecturethree
{
    internal class TechnicalExercise1
    {
        public void TechnicalExerc1()
        {
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n even numbers from 1 to 50");

            for (int i = 1; i < 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);   
                }
                
            }

        }

    }
}
