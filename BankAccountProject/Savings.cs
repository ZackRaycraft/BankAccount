using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Savings : Account
    {
        private int savingsBalance;
        private int depositSavings;
        private int withdrawSavings;

        public int ReserveBalance
        {
            get { return this.savingsBalance; }
            set { this.savingsBalance = value; }
        }

        public int DepositReserve
        {
            get { return this.depositSavings; }
            set { this.depositSavings = value; }
        }

        public int WithdrawReserve
        {
            get { return this.withdrawSavings; }
            set { this.withdrawSavings = value; }
        }

        public override void PrintAccountInfo()
        {
            Console.WriteLine("Savings account balance is $" + savingsBalance);
        }




        public Savings(int savingsBalance) : base("John Doe", 123456789)
        {
            this.savingsBalance = savingsBalance;

        }
    }
}
