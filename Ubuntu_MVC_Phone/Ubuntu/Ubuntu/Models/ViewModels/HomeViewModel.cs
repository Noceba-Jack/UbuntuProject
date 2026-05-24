namespace Ubuntu.Models.ViewModels
{
    public class HomeViewModel
    {
        public string MerchantName { get; set; } = "Abdul Merchant";
        public string MerchantId { get; set; } = "#UBM-00421";
        public string AccountBalance { get; set; } = "R 24,580.00";
        public int CustomerCount { get; set; } = 48;
        public string LoansDue { get; set; } = "R 3,200";
        public string LoansLabel { get; set; } = "A 6 pending";

        public List<Transaction> RecentTransactions { get; set; } = new()
        {
            new Transaction { CustomerName = "Sipho Dlamini", Type = TransactionType.Deposit, Amount = 100, Date = DateTime.Now.AddHours(-1), Description = "Deposit" },
            new Transaction { CustomerName = "Nomsa Jack", Type = TransactionType.Withdrawal, Amount = 250, Date = DateTime.Now.AddHours(-2), Description = "Withdrawal" },
            new Transaction { CustomerName = "Thabo Mokoena", Type = TransactionType.LoanGranted, Amount = 50, Date = DateTime.Now.AddDays(-1).AddHours(-3), Description = "Loan Granted" },
            new Transaction { CustomerName = "Zanele Khumalo", Type = TransactionType.LoanRepaid, Amount = 50, Date = DateTime.Now.AddDays(-1).AddHours(-6), Description = "Loan Repaid" }
        };
    }
}
