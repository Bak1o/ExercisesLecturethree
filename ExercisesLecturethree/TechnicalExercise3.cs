using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ExercisesLecturethree
{
    internal class TechnicalExercise3
    {
        public void TechnicalExerc3()
        {
            int userNumber;
            int count = 0;
            string answer;
            string question = " do you want to continue ";

            //Console.WriteLine(" please enter numbers whith value less than 10 ");
            do
            {
                
                Console.WriteLine(" please enter numbers whith value less than 10 ");
                userNumber = int.Parse(Console.ReadLine());

                if (userNumber >= 10)
                {
                    
                    Console.WriteLine(" program ends beaceuse you didn't enter number value less than 10 ");
                    do
                    {
                        Console.WriteLine(question);
                        answer = Console.ReadLine();
                        count++;
                        
                        

                    }
                    while (count < 3 && answer.Equals("yes"));
                    
                    
                }
                
            }
           
            while (userNumber < 10);


            
        }
    }
}
