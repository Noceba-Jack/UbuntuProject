namespace Ubuntu.Models
{
    public enum CustomerStatus
    {
        Active,
        HasLoan,
        Overdue
    }

    public class Customer
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Initials { get; set; } = string.Empty;
        public decimal Balance { get; set; }
        public int UbuntuScore { get; set; }
        public decimal LoanDue { get; set; }
        public CustomerStatus Status { get; set; }
        public List<string> RecentActivity { get; set; } = new();

        // Derived display properties
        public string BalanceDisplay => $"R {Balance:N2}";
        public string LoanDueDisplay => LoanDue > 0 ? $"R {LoanDue:N2}" : "R 0.00";
        public string UbuntuScoreDisplay => $"{UbuntuScore}/100";
    }
}
