namespace Ubuntu.Models.ViewModels
{
    public class LoginViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string ErrorMessage { get; set; }
        public bool HasError { get; set; }
    }

}
