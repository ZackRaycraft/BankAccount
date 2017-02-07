using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Account
    {
        private string name = "John Doe";

        private int accountNumber = 123456789;
        private int withdraw;
        public int answer;
        

        private string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        private int AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }


        public int Withdraw
        {
            get { return this.withdraw; }
            set { this.withdraw = value; }

        }

        public Account()
        {

        }

        public Account(string name, int accountNumber)
        {
            this.name = name;
            this.accountNumber = accountNumber;
            
        }

        public virtual void PrintAccountInfo()
        {
            Console.WriteLine("Hello " + name + "! Welcome to your online bank.");
            Console.WriteLine("You're account number is " + accountNumber + ".");
        }

        public void PrintAccountOptions()
        {
            Console.WriteLine("Press 1 to withdraw from your checking account");
            Console.WriteLine("Press 2 to deposit into your checking account");
            Console.WriteLine("Press 3 to withdraw from your reserve account");
            Console.WriteLine("Press 4 to deposit into your reserve account");
            Console.WriteLine("Press 5 to withdraw from your savings account");
            Console.WriteLine("Press 6 to deposit into your savings account");
        }




    }
}
