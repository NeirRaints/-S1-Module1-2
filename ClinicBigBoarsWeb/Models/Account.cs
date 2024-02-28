using System.ComponentModel.DataAnnotations;

namespace ClinicBigBoarsWeb.Models
{
    public class Account
    {
        [Key]
        [MinLength(5, ErrorMessage ="Длина строки должна содержать минимум 5 символов")]
        public int Login { get; set; }
        [MinLength(5, ErrorMessage = "Длина строки должна содержать минимум 5 символов")]
        [DataType(DataType.Password)]
        public required string Password { get; set; }
    }
}
