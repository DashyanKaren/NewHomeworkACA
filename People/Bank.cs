using System;

public abstract class Banking
{
    
    public abstract int CardId { get;   set; }
    public int BankAmount { get; set; }
    public abstract int CryptoId { get; set; }
    public  int CryptoAmount { get; set; }

    

    public virtual void Withdraw(int sum, int id)
    {
        if (id == CardId && sum <= BankAmount)
        {
            BankAmount -= sum;
        }
        else 
         CryptoAmount -= sum;
    }

    public  virtual void Add(int sum, int id)
    {
        if (id == CardId)
        {
            BankAmount += sum;
        }
        else CryptoAmount += sum;
    }
    


}

