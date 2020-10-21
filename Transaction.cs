using System; 

namespace Account 
{
    public class Transaction{
        public decimal Amount {get; }
        public DateTime Date { get; }
        public string For { get;  }

        public Transaction(decimal amount, DateTime date, string _for) {
            Amount = amount; 
            Date = date; 
            For = _for; 
        }
    }
}