using Microsoft.AspNetCore.Mvc;
using Ubuntu.Models.ViewModels;

namespace Ubuntu.Controllers
{
    public class LoanController : Controller
    {
        // ── MVC Views ──
        [HttpGet]
        public IActionResult Index() => View(new LoanViewModel());

        [HttpPost]
        public IActionResult LendLookup(LoanViewModel model)
        {
            if (!string.IsNullOrWhiteSpace(model.LendLoanNo)) model.LendStep = "accept";
            return View("Index", model);
        }

        [HttpPost]
        public IActionResult LendAccept(LoanViewModel model)
        {
            model.LendStep = "success";
            return View("Index", model);
        }

        [HttpPost]
        public IActionResult LendDecline(LoanViewModel model)
        {
            model.LendLoanNo = string.Empty;
            model.LendStep   = "form";
            return View("Index", model);
        }

        [HttpPost]
        public IActionResult SettleFind(LoanViewModel model)
        {
            if (!string.IsNullOrWhiteSpace(model.SettleLoanNo)) model.SettleStep = "details";
            return View("Index", model);
        }

        [HttpPost]
        public IActionResult SettleConfirm(LoanViewModel model)
        {
            model.SettleStep = "success";
            return View("Index", model);
        }

        [HttpPost]
        public IActionResult SettleDone(LoanViewModel model)
        {
            model.SettleLoanNo = string.Empty;
            model.SettleAmount = 0;
            model.SettleStep   = "form";
            return View("Index", model);
        }

        // ── API endpoints ──
        [HttpGet("/api/loans")]
        public IActionResult ApiLoans()
        {
            var vm = new LoanViewModel();
            return Json(new {
                totalLent      = vm.TotalLent,
                totalQueue     = vm.TotalQueue,
                availableToLend = vm.AvailableToLend,
                ubuntuScoreAvg = vm.UbuntuScoreAvg
            });
        }

        [HttpGet("/api/loan/lookup/{loanNo}")]
        public IActionResult ApiLoanLookup(string loanNo)
        {
            if (string.IsNullOrWhiteSpace(loanNo))
                return Json(new { found = false, error = "Loan number required." });

            // Simulated loan lookup
            return Json(new {
                found        = true,
                loanNo       = loanNo,
                customerName = "Sipho Dlamini",
                amount       = "R 5,000.00",
                ubuntuScore  = "82/100",
                status       = "Pending"
            });
        }

        [HttpPost("/api/loan/accept")]
        public IActionResult ApiLoanAccept([FromBody] LoanViewModel model)
        {
            if (string.IsNullOrWhiteSpace(model.LendLoanNo))
                return Json(new { success = false, error = "Loan number required." });

            return Json(new {
                success = true,
                message = $"Loan {model.LendLoanNo} has been approved and issued."
            });
        }

        [HttpGet("/api/loan/settle/find/{loanNo}")]
        public IActionResult ApiSettleFind(string loanNo)
        {
            if (string.IsNullOrWhiteSpace(loanNo))
                return Json(new { found = false, error = "Loan number required." });

            return Json(new {
                found        = true,
                loanNo       = loanNo,
                customerName = "Zanele Khumalo",
                outstanding  = "R 3,200.00"
            });
        }

        [HttpPost("/api/loan/settle/confirm")]
        public IActionResult ApiSettleConfirm([FromBody] LoanViewModel model)
        {
            if (string.IsNullOrWhiteSpace(model.SettleLoanNo) || model.SettleAmount <= 0)
                return Json(new { success = false, error = "Please provide loan number and amount." });

            return Json(new {
                success = true,
                message = $"R {model.SettleAmount:N2} settled on loan {model.SettleLoanNo}."
            });
        }
    }
}
