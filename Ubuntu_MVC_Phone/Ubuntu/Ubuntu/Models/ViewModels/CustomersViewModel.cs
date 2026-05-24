namespace Ubuntu.Models.ViewModels
{
    public class CustomersViewModel
    {
        public string SearchText { get; set; } = string.Empty;
        public string ActiveFilter { get; set; } = "All";
        public List<Customer> FilteredCustomers { get; set; } = new();
    }
}
