using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Bank
{
    internal class BankAccount : BaseAccount
    {
        public List <BankAccount> bankAccounts= new List<BankAccount>();
        private BankLimit bankLimit;

        public BankAccount(string accountNumber, Currency currency, BankLimit limit)
            : base(accountNumber, currency)
        {
            bankLimit = limit;
        }
        public void AddaToBank(BankAccount bankAccount)
        {
            bankAccounts.Add(bankAccount);
        }

        public override void DoDeposit(double amount)
        {
            if (bankLimit.IsInDayLimit(amount))
            { base.DoDeposit(amount); }
        }
    }
}
