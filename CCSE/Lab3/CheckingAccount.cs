using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class CheckingAccount : BankAccount
    {
        
        int numWithdraws = 0;
        int MAXWITHDRAWS = 2;
        float withdrawFee = 0.25f;

        public CheckingAccount() : base(0f) {

        }

        public CheckingAccount(float bal) {
            base.balance = bal;
        }

        public override void withdraw(float amount)
        {
            float totalremoved = amount;
            if (numWithdraws >= MAXWITHDRAWS){
                totalremoved += withdrawFee;
            }

            base.withdraw(totalremoved);
            numWithdraws++;
        }

    }
}
