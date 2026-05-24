namespace Ubuntu.Models
{
    public enum TransactionType
    {
        Deposit,
        Withdrawal,
        LoanGranted,
        LoanRepaid
    }

    public class Transaction
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string CustomerName { get; set; } = string.Empty;
        public TransactionType Type { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string Description { get; set; } = string.Empty;

        public string AmountDisplay => Type == TransactionType.Deposit || Type == TransactionType.LoanRepaid
            ? $"+R{Amount:N0}"
            : $"-R{Amount:N0}";
    }
}
