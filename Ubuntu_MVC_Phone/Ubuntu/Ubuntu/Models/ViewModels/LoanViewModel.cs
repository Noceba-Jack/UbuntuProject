namespace Ubuntu.Models.ViewModels
{
    public class LoanViewModel
    {
        // Summary
        public string TotalLent { get; set; } = "R 1,850";
        public string TotalQueue { get; set; } = "R 2,400";
        public string AvailableToLend { get; set; } = "R 8,200";
        public string UbuntuScoreAvg { get; set; } = "74/100";

        // Lend
        public string LendLoanNo { get; set; } = string.Empty;
        public string LendStep { get; set; } = "form"; // form | accept | success

        // Settlement
        public string SettleLoanNo { get; set; } = string.Empty;
        public decimal SettleAmount { get; set; }
        public string SettleStep { get; set; } = "form"; // form | details | confirm | success
    }
}
