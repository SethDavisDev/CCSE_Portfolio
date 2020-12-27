using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class SavingsAccount : BankAccount
    {
        float yearlyInterestRate = 0.05f;
        float calcedInterest;

        public SavingsAccount() : base(0f) { }

        public SavingsAccount(float amount) : base(amount) {

        }

        public float getInterest () {
            return calcedInterest;
        }

        public void setInterest(int numMonths) {
            if (balance <= 0f) return;
            for (int i = 0; i < numMonths; i++)
            {
                calcedInterest = balance * (yearlyInterestRate / 12);
                balance += calcedInterest;
            }
        }

        public override float getBalance() {
            setInterest(2);
            balance += calcedInterest;
            return balance;
        }

    }
}
