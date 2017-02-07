using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
     class Checking : Account
    {
        private int checkingBalance;
        private int depositChecking;
        private int withdrawChecking;

        public int CheckingBalance
        {
            get { return this.checkingBalance; }
            set { this.checkingBalance = value; }
        }

        public int DepositChecking
        {
            get { return this.depositChecking; }
            set { this.depositChecking = value; }
        }

        public int WithdrawChecking
        {
            get { return this.withdrawChecking; }
            set { this.withdrawChecking = value + answer; }
        }

        public override void PrintAccountInfo()
        {
            Console.WriteLine("Checking account balance is $" + checkingBalance);
        }


        public Checking(int checkingBalance) : base("John Doe", 123456789)
        {
            this.checkingBalance = checkingBalance;
        }

        public int Deposit()
        {
            CheckingBalance++;
            return CheckingBalance;
        }
        
            
            
        

       

        

        
    }
}
