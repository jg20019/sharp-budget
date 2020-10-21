using System; 
using System.Collections.Generic; 
using System.Linq; 

namespace Account
{
    public class Account
    {
        private List<Transaction> transactions; 
        
        public Account()
        {
            transactions = new List<Transaction>(); 
        }
        public void Deposit(decimal amount, DateTime date, string _for) 
        {
            if (amount <= 0) {
                throw new Exception("amount has to be greater than 0."); 
            }
            Transaction transaction = new Transaction(amount, date, _for);
            transactions.Add(transaction);  
        }

        public void Withdraw(decimal amount, DateTime date, string _for)
        {
            if (amount <= 0) {
                throw new Exception("withdraw amount has to be greater than 0"); 
            }

            if (amount > Balance()) {
                throw new Exception("withdraw amount exceeds available funds"); 
            }

            Transaction transaction = new Transaction(amount, date, _for); 
            transactions.Add(transaction); 
        }
        public decimal Balance()
        {
            return transactions.Aggregate(0M, (total, transaction) => 
                total + transaction.Amount, 
                total => total); 
        }
    }
}