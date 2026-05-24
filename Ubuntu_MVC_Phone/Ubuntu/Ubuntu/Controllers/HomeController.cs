using Microsoft.AspNetCore.Mvc;
using Ubuntu.Models.ViewModels;

namespace Ubuntu.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var vm = new HomeViewModel();
            return View(vm);
        }

        [HttpGet("/api/home")]
        public IActionResult ApiHome()
        {
            var vm = new HomeViewModel();
            return Json(new
            {
                merchantName    = vm.MerchantName,
                merchantId      = vm.MerchantId,
                accountBalance  = vm.AccountBalance,
                customerCount   = vm.CustomerCount,
                loansDue        = vm.LoansDue,
                loansLabel      = vm.LoansLabel,
                recentTransactions = vm.RecentTransactions.Select(t => new
                {
                    customerName  = t.CustomerName,
                    description   = t.Description,
                    amountDisplay = t.AmountDisplay,
                    date          = t.Date.ToString("dd MMM yyyy HH:mm"),
                    type          = t.Type.ToString()
                })
            });
        }
    }
}
