using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Mainmenu:

            Account account = new Account();
            Checking checking = new Checking(1000);
            Reserve reserve = new Reserve(1000);
            Savings savings = new Savings(1000);

            account.PrintAccountInfo();
            checking.PrintAccountInfo();
            reserve.PrintAccountInfo();
            savings.PrintAccountInfo();

            account.PrintAccountOptions();
            Console.WriteLine();
            int userInput = int.Parse(Console.ReadLine());

            while (userInput == userInput)
            {
                if (userInput == 1)
                {
                    Console.WriteLine("How much do you wish to withdraw?");
                    checking.WithdrawChecking = int.Parse(Console.ReadLine());
                    checking.CheckingBalance = checking.CheckingBalance - checking.WithdrawChecking;
                    goto Mainmenu;
                }

                else if (userInput == 2)
                {
                    Console.WriteLine("How much do you wish to deposit?");
                    int answer = int.Parse(Console.ReadLine());
                    checking.Deposit();
                    goto Mainmenu;
                }

                else if (userInput == 3)
                {

                    goto Mainmenu;
                }

                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter a number 1-6");
                    Console.WriteLine();
                    goto Mainmenu;
                }
            }









                    //Console.WriteLine("enter number to deposit into checking");
                    //int userInput = int.Parse(Console.ReadLine());
                    //checking.DepositChecking = userInput;
                    //checking.CheckingBalance = checking.CheckingBalance + checking.DepositChecking;
                    //checking.PrintAccountInfo();










                }
    }
}
