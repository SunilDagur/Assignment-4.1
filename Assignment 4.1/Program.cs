using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4._1
{


    public class BankAccount
    {
        private decimal balance;
        public BankAccount(decimal initialBalance)
        {
            if (initialBalance < 0)
            {
                throw new ArgumentException("Initial balance cannot be negative.");
            }

            balance = initialBalance;
        }

       
        public decimal Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Balance cannot be set to a negative value.");
                }
                balance = value;
            }
        }

      
        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Deposit amount cannot be negative.");
            }
            balance += amount;
        }

       
        public void Withdraw(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Withdrawal amount cannot be negative.");
            }

            if (amount > balance)
            {
                throw new InvalidOperationException("Insufficient balance for withdrawal.");
            }

            balance -= amount;
        }
    }
}
