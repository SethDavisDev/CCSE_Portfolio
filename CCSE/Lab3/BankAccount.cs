using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class BankAccount
    {
        static Random rand = new Random();
        protected long accountNumber;
        protected float balance;
        protected float minBalance = 1.00f;
        public float MinBalance { get { return this.minBalance; } }
        public BankAccount() : this(0f){

        }

        
        public BankAccount(float bal) {
            balance = bal;
            accountNumber = rand.Next(1000000);

        }

        //when printing this will pad with zeros
        public long getAccountNum() {
            return accountNumber;
        }
        public virtual float getBalance() {
            return balance;
        }
        public void deposit(float amount) {
            if (amount <= 0) {
                return;
            }
            balance += amount;
        }
        public virtual void withdraw(float amount) {
            if (amount <= 0) {  
                return;
            }
            if (amount > balance - minBalance) {
                balance = minBalance;
                return;
            }
            balance -= amount;


        }

    }
}
