using Microsoft.AspNetCore.Mvc;
using Ubuntu.Models.ViewModels;

namespace Ubuntu.Controllers
{
    public class TransactController : Controller
    {
        // ── MVC Views ──
        [HttpGet]
        public IActionResult Deposit() => View(new TransactViewModel());

        [HttpPost]
        public IActionResult Deposit(TransactViewModel model)
        {
            if (model.DepositAmount > 0 && !string.IsNullOrWhiteSpace(model.DepositAccountNo))
            {
                model.DepositStep = "verify";
                return View(model);
            }
            ModelState.AddModelError("", "Please enter valid deposit details.");
            return View(model);
        }

        [HttpPost]
        public IActionResult ConfirmDeposit(TransactViewModel model)
        {
            model.DepositStep = "success";
            return View("Deposit", model);
        }

        [HttpGet]
        public IActionResult Withdraw() => View(new TransactViewModel());

        [HttpPost]
        public IActionResult Withdraw(TransactViewModel model)
        {
            if (!string.IsNullOrWhiteSpace(model.WithdrawAccountNo) && !string.IsNullOrWhiteSpace(model.WithdrawCode))
            {
                model.WithdrawStep = "verify";
                return View(model);
            }
            ModelState.AddModelError("", "Please enter valid withdrawal details.");
            return View(model);
        }

        [HttpPost]
        public IActionResult ConfirmWithdraw(TransactViewModel model)
        {
            model.WithdrawStep = "success";
            return View("Withdraw", model);
        }

        // ── API endpoints ──
        [HttpPost("/api/deposit")]
        public IActionResult ApiDeposit([FromBody] TransactViewModel model)
        {
            if (model.DepositAmount <= 0 || string.IsNullOrWhiteSpace(model.DepositAccountNo))
                return Json(new { success = false, error = "Please enter valid deposit details." });

            // Simulate processing
            return Json(new {
                success = true,
                message = $"R {model.DepositAmount:N2} deposited to account {model.DepositAccountNo}",
                newBalance = "R 48,750.00"   // would come from real data layer
            });
        }

        [HttpPost("/api/withdraw")]
        public IActionResult ApiWithdraw([FromBody] TransactViewModel model)
        {
            if (string.IsNullOrWhiteSpace(model.WithdrawAccountNo) || string.IsNullOrWhiteSpace(model.WithdrawCode))
                return Json(new { success = false, error = "Please enter valid withdrawal details." });

            return Json(new {
                success = true,
                message = $"Withdrawal from {model.WithdrawAccountNo} approved",
                newBalance = "R 47,950.00"
            });
        }
    }
}
