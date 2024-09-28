using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesLecturethree
{
    internal class PracticalExercise2
    {
        public void PracticalExerc2()
        {
            double score, sum, averageScore, count;
            string answer;
            sum = 0;
            count = 0;

            do
            {
                Console.WriteLine(" please enter your score ");
                score = double.Parse(Console.ReadLine());
                sum += score;
                count++;
                Console.WriteLine(" if you wish to continue answer : 'yes' or 'y' ");
                answer = Console.ReadLine();

            }
            while (answer.Equals("yes") || answer.Equals("y")); 

            averageScore = sum / count;
            Console.WriteLine($" average score is : {averageScore} ");
        }
    }
}
