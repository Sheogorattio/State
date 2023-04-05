using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    
    public class SilverState : State
    {
        private void Initialize()
        {
            interest = 0.01;
            lowerLimit = 0.0;
            upperLimit = 1000.0;
        }
        private void StateChangeCheck()
        {
            if (balance < lowerLimit)
            {
                account.SetState(new RedState(this));
            }
            else if (balance > upperLimit)
            {
                account.SetState(new GoldState(this));
            }
        }
        public SilverState(double balance, Account account)
        {
	        this.balance = balance;
	        this.account = account;
	        Initialize();
        }
        public override void Deposit(double amount)
        {
            throw new NotImplementedException();
        }

        public override bool PayInterest()
        {
            throw new NotImplementedException();
        }

        public override bool Withdraw(double amount)
        {
            throw new NotImplementedException();
        }
    }
}
