using System.ComponentModel.DataAnnotations;

namespace ERPTP.ViewModel
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}