using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesLecturethree
{
    internal class TechnicalExercise2
    {
        public void TechnicalExerc2()
        {
            int number1, number2, sum, count;
            number1 = 0;
            sum = 0;
            count = 0;
            while (number1 < 50)
            {
                number1++;
                Console.WriteLine(number1);
            }
            Console.WriteLine(" please enter five number ");

            while (count < 5)
            {
                number2 = int.Parse(Console.ReadLine());
                sum += number2;
                count++;
            }

            Console.WriteLine($" the sum of numbers you entered is : {sum}");
                
            

        }
    }
}
