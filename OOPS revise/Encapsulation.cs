using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_revise
{
    internal class Account
    {
       private int AccountNo;
       private int AccountBalance;

        public void setdepositMoney(int money)
        {
            if (money > 0) { this.AccountBalance = money; }
            else
            {
                Console.WriteLine("please deposit above 0");
            }
           
        }

        public double getDepositMoney()
        {
            if (this.AccountBalance > 0)
            {
                return this.AccountBalance;
            }
            else
            {
                Console.WriteLine("your balance is not available");
                return 0;
            }
        }

    }
}
