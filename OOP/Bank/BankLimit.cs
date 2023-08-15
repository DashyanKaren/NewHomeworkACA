using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Bank
{
    public class BankLimit
    {
        private double withdrawalLimitPerDay = double.MaxValue / 2;
        private double currentWithdrawalInDay = 0;
        private DateTime lastWithdrawTime = DateTime.Now;

        public bool IsInDayLimit(double amount)
        {

            if ((DateTime.Now - lastWithdrawTime).TotalDays > 1)
            {
                resetLimit();
            }
            if ((DateTime.Now - lastWithdrawTime).TotalDays <= 1 && currentWithdrawalInDay + amount < withdrawalLimitPerDay)
            {
                currentWithdrawalInDay += amount;
                lastWithdrawTime = DateTime.Now;
                return true;
            }
            else { return false; }
        }

        private void resetLimit()
        {
            currentWithdrawalInDay = 0;
            lastWithdrawTime = DateTime.Now;
        }

    }
}
