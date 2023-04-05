using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    abstract public class State
    {
        protected Account account;
        protected double balance;
        protected double interest;
        protected double lowerLimit;
        protected double upperLimit;
        public Account GetAccount() { return account; }
        public double GetBalance() { return balance; }
        public void SetAccount(Account obj) { account = obj; }
        public void SetInterest(double value) { balance = value;}
        abstract public void Deposit(double amount);
        abstract public bool Withdraw(double amount);
        abstract public bool PayInterest();
    }
}
