using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesLecturethree
{
    internal class PracticalExercise1
    {
        public void practicalExerc1()
        {
            string answer;
            decimal price,sum;
            sum = 0;

            do
            {
                Console.WriteLine(" please enter the price of product ");
                price = decimal.Parse(Console.ReadLine());
                sum += price;
                Console.WriteLine(" if you wish to continue answer : 'yes' or 'y' ");
                answer = Console.ReadLine();
                

            }
            while ((answer.Equals("yes")) || (answer.Equals("y")));
            Console.WriteLine($" total cost of products you entered is : {sum}");


        }
    }
}
