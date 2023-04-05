using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Account
    {
        State state;
        string owner;
        public Account(string owner)
        {
            this.owner = owner;
        }
        public double GetBalance()
        {
            return state.GetBalance();
        }
        public State GetState()
        {
            return state;
        }
        public void SetState(State state)
        {
            this.state = state;
        }
        public void Deposit(double amount)
        {
            state.Deposit(amount);
            Console.WriteLine($"Deposited {amount}$ ----");
            Console.WriteLine($"Balance {state.GetBalance()}$ ----");
            Console.WriteLine($"Status {state}");
            
        }
        public void Withdraw(double amount)
        {
            if(state.Withdraw(amount))
            {
                Console.WriteLine($"Withdraw {amount}$ ----");
                Console.WriteLine($"Balance {state.GetBalance()} ----");
                Console.WriteLine($"Status {state} ----");
            }
        }
        public void PayInterest()
        {
            if (state.PayInterest())
            {
                Console.WriteLine($"Interest paid ----");
                Console.WriteLine($"Balace {state.GetBalance()}");
                Console.WriteLine($"Status {state}");
            }
        }
    }
}
