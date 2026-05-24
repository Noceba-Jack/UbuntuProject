using Microsoft.AspNetCore.Mvc;
using Ubuntu.Models;
using Ubuntu.Models.ViewModels;

namespace Ubuntu.Controllers
{
    public class CustomersController : Controller
    {
        private readonly List<Customer> _allCustomers;

        public CustomersController()
        {
            _allCustomers = new List<Customer>
            {
                new Customer { Id="UBC-001", Name="Sipho Dlamini",   Balance=1240, UbuntuScore=82, LoanDue=0,   Status=CustomerStatus.Active,
                    RecentActivity = new() { "Deposit R500 · 20 May", "Withdrawal R200 · 18 May", "Account opened · 01 Jan" } },
                new Customer { Id="UBC-002", Name="Nomsa Jack",      Balance=380,  UbuntuScore=67, LoanDue=50,  Status=CustomerStatus.HasLoan,
                    RecentActivity = new() { "Loan issued R50 · 15 May", "Deposit R200 · 10 May" } },
                new Customer { Id="UBC-003", Name="Thabo Mokoena",   Balance=120,  UbuntuScore=54, LoanDue=80,  Status=CustomerStatus.Overdue,
                    RecentActivity = new() { "Overdue notice · 22 May", "Loan issued R80 · 01 May" } },
                new Customer { Id="UBC-004", Name="Zanele Khumalo",  Balance=2100, UbuntuScore=91, LoanDue=0,   Status=CustomerStatus.Active,
                    RecentActivity = new() { "Deposit R1000 · 21 May", "Withdrawal R500 · 19 May" } },
                new Customer { Id="UBC-005", Name="Bongani Zulu",    Balance=650,  UbuntuScore=73, LoanDue=200, Status=CustomerStatus.HasLoan,
                    RecentActivity = new() { "Loan issued R200 · 12 May", "Deposit R300 · 08 May" } },
                new Customer { Id="UBC-006", Name="Lerato Motha",    Balance=90,   UbuntuScore=44, LoanDue=150, Status=CustomerStatus.Overdue,
                    RecentActivity = new() { "Overdue notice · 23 May", "Loan issued R150 · 02 May" } },
                new Customer { Id="UBC-007", Name="Mpho Sithole",    Balance=3400, UbuntuScore=88, LoanDue=0,   Status=CustomerStatus.Active,
                    RecentActivity = new() { "Deposit R2000 · 20 May", "Withdrawal R1000 · 17 May" } },
            };
        }

        // ── MVC Views ──
        public IActionResult Index(string searchText = "", string filter = "All")
        {
            var results = _allCustomers.Where(c =>
                (string.IsNullOrWhiteSpace(searchText) ||
                 c.Name.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                 c.Id.Contains(searchText, StringComparison.OrdinalIgnoreCase)) &&
                (filter == "All" ||
                 (filter == "Active"   && c.Status == CustomerStatus.Active) ||
                 (filter == "Has Loan" && c.Status == CustomerStatus.HasLoan) ||
                 (filter == "Overdue"  && c.Status == CustomerStatus.Overdue))
            ).ToList();

            return View(new CustomersViewModel
            {
                SearchText        = searchText,
                ActiveFilter      = filter,
                FilteredCustomers = results
            });
        }

        public IActionResult Detail(string id)
        {
            var customer = _allCustomers.FirstOrDefault(c => c.Id == id);
            if (customer == null) return NotFound();
            return View(customer);
        }

        // ── API endpoints ──
        [HttpGet("/api/customers")]
        public IActionResult ApiCustomers(string? search = "", string? filter = "All")
        {
            var results = _allCustomers.Where(c =>
                (string.IsNullOrWhiteSpace(search) ||
                 c.Name.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                 c.Id.Contains(search, StringComparison.OrdinalIgnoreCase)) &&
                (filter == "All" ||
                 (filter == "Active"   && c.Status == CustomerStatus.Active) ||
                 (filter == "Has Loan" && c.Status == CustomerStatus.HasLoan) ||
                 (filter == "Overdue"  && c.Status == CustomerStatus.Overdue))
            ).Select(c => new {
                id             = c.Id,
                name           = c.Name,
                balance        = c.BalanceDisplay,
                loanDue        = c.LoanDueDisplay,
                ubuntuScore    = c.UbuntuScoreDisplay,
                status         = c.Status.ToString(),
                initials       = string.Join("", c.Name.Split(' ').Take(2).Select(w => w[0]))
            });
            return Json(results);
        }

        [HttpGet("/api/customers/{id}")]
        public IActionResult ApiCustomerDetail(string id)
        {
            var c = _allCustomers.FirstOrDefault(x => x.Id == id);
            if (c == null) return NotFound();
            return Json(new {
                id             = c.Id,
                name           = c.Name,
                balance        = c.BalanceDisplay,
                loanDue        = c.LoanDueDisplay,
                ubuntuScore    = c.UbuntuScoreDisplay,
                status         = c.Status.ToString(),
                initials       = string.Join("", c.Name.Split(' ').Take(2).Select(w => w[0])),
                recentActivity = c.RecentActivity
            });
        }
    }
}
