namespace Ubuntu.Models.ViewModels
{
    public class TransactViewModel
    {
        // Deposit
        public decimal DepositAmount { get; set; }
        public string DepositAccountNo { get; set; } = string.Empty;
        public string DepositStep { get; set; } = "form"; // form | verify | success

        // Withdraw
        public string WithdrawAccountNo { get; set; } = string.Empty;
        public string WithdrawCode { get; set; } = string.Empty;
        public string WithdrawStep { get; set; } = "form"; // form | verify | success
    }
}
