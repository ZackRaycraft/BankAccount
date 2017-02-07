using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Reserve : Account
    {
        private int reserveBalance;
        private int depositReserve;
        private int withdrawReserve;

        public int ReserveBalance
        {
            get { return this.reserveBalance; }
            set { this.reserveBalance = value; }
        }

        public int DepositReserve
        {
            get { return this.depositReserve; }
            set { this.depositReserve = value; }
        }

        public int WithdrawReserve
        {
            get { return this.withdrawReserve; }
            set { this.withdrawReserve = value; }
        }

        public override void PrintAccountInfo()
        {
            Console.WriteLine("Reserve account balance is $" + reserveBalance);
        }






        public Reserve(int reserveBalance) : base("John Doe", 123456789)
        {
            this.reserveBalance = reserveBalance;

        }

    }
}
