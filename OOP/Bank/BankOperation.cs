using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Bank
{
    internal class BankOperation
    {
        public bool TranferToAccount(BaseAccount from, BaseAccount to, double amount)
        {
            if (from == null || to == null) throw new ArgumentNullException("From/To account can be null");
            if (from.Currency != to.Currency)
                throw new InvalidOperationException("Transfer between diferent currencies not alowed");
            from.DoWithdrawal(amount);
            to.DoDeposit(amount);
            return true;
        }
        
        

    }
}
