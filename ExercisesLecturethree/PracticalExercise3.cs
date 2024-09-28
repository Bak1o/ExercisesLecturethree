using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesLecturethree
{
    internal class PracticalExercise3
    {
        public void PracticalExerc3()
        {
            decimal addMoney, takeMoney, balance, sumIncome, sumExpences;
            balance = 0;
            sumIncome = 0;
            sumExpences = 0;
            addMoney = 0;
            takeMoney = 0;
          
            string typeOperationAnswer, continueOperationAnswer;
            do
            {
                Console.WriteLine(" hello if you want to take money from your account answer : 1, " +
                "to add money answer: 2 , to check balance answer : 3 ");
                typeOperationAnswer = Console.ReadLine();
                if (typeOperationAnswer.Equals("2"))
                {
                    Console.WriteLine(" enter money amount you want to add  your account ");
                    addMoney = decimal.Parse(Console.ReadLine());
                    balance += addMoney;
                    sumIncome += addMoney;


                }
                else if (typeOperationAnswer.Equals("1"))
                {
                    Console.WriteLine(" enter money amount you want to take from your account ");
                    takeMoney = decimal.Parse(Console.ReadLine());
                    if (balance < takeMoney)
                    {
                        Console.WriteLine(" you don't have enough money on your account ");
                    }
                    else
                    {
                        balance -= takeMoney;
                        sumExpences += takeMoney;
                    }

                }
                else if (typeOperationAnswer.Equals("3"))
                {
                    Console.WriteLine($"balance is : {balance}");
                }
               
                Console.WriteLine(" \nif you want to continue answer: 'yes' or 'y' ");
                continueOperationAnswer = Console.ReadLine();
                
                


            }
            while (continueOperationAnswer.Equals("yes") || continueOperationAnswer.Equals("y"));

            Console.WriteLine($" your total income is {sumIncome}");
            Console.WriteLine($" your  total expence is {sumExpences}");




        }
    }
}
