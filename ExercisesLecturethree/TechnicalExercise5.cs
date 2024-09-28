using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesLecturethree
{
    internal class TechnicalExercise5
    {
        public void TechnicalExerc5()
        {
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0 && !(i % 5 == 0))
                {
                    Console.WriteLine(" Fizz ");
                }
                else if (i % 5 == 0 && !(i % 3 == 0))
                {
                    Console.WriteLine(" Buzz ");
                }

                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(" FizzBuzz ");
                }

                else 
                {
                    Console.WriteLine(i); 
                }


            }

        }
    }
}
