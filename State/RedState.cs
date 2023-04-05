using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class RedState:State
    {
        void Initialize()
        {
            interest = 0.0;
            lowerLimit = 0.0;
            upperLimit = 0.0;
        }
         void StateChangeCheck()
        {
            if(balance > upperLimit)
            {
                account.SetState(new SilverState(this));
            }
        }
        public RedState(State state)
        {
            this.balance = state.GetBalance();
            this.account = state.GetAccount();
        }
        public override string ToString() { return "Red state"; }
       override public void Deposit(double amount)
        {
            balance += amount;
            StateChangeCheck();
        }
        override public bool Withdraw(double amount)
        {
            Console.WriteLine("No funds available for withdraw");
            return false;
        }
        public override bool PayInterest()
        {
            Console.WriteLine("No interest is paid!");
            return false;
        }

    }
}
