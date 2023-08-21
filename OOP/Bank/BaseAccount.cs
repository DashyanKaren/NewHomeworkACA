using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Bank
{
    internal class BaseAccount
    {
       
        public string AccountNumber { get; }
        public double Balance { get; private set; }
        public Currency Currency { get; }

        public BaseAccount(string accountNumber, Currency currency)
        {
            AccountNumber = accountNumber;
            Currency = currency;
        }
        public BaseAccount(string accountNumber, Currency currency, double balance)
            : this(accountNumber, currency)
        {
            Balance = balance;
        }
        public virtual void DoDeposit(double amount)
        {
            if (amount <= 0)
            {
                throw new InvalidOperationException("Deposit amount can't be 0");
            }
            Balance += amount;
        }

        public virtual double DoWithdrawal(double amount)
        {
            if (amount > Balance)
            {
                throw new InvalidOperationException("Not enough money");
            }
            Balance -= amount;
            return amount;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine(ToString());
        }
        public override string ToString()
        {
            return $"Account Number {AccountNumber} Currency {Currency} Amount {Balance}";
        }

    }

    public enum Currency : byte
    {
        AMD=1,
        EUR=2,
        USD=3,
        Crypto=4
    }

}
