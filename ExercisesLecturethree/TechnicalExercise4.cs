using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesLecturethree
{
    internal class TechnicalExercise4
    {
        public void TechnicalExerc4()
        {
            char star = '*';
            for (int i = 0; i < 5; i++)
            {
                
                Console.WriteLine("\n");
                for (int j = 0; j < 5; j++)
                {
                    
                    if (i == 0 && j == 4)
                    {
                        Console.Write(star);
                    }
                    else if (i == 1 && j > 2)
                    {
                        Console.Write(star);
                    }
                    else if (i == 2 && j > 1)
                    {
                        Console.Write(star);
                    }

                    else if (i == 3 && j > 0)
                    {
                        Console.Write(star);
                    }

                    else if (i == 4 && j >= 0)
                    {
                        Console.Write(star);
                    }
                   

                }
            }
        }
    }
}
