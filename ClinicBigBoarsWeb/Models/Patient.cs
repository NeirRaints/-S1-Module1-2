using ClinicBigBoarsWeb.Data.Enum;
using System.ComponentModel.DataAnnotations;

namespace ClinicBigBoarsWeb.Models
{
    public class Patient
    {
        [Key]
        [Display(Name = "Номер пациента")]
        public int PatientId { get; set; }

        [Display(Name = "Фото")]
        [DataType(DataType.ImageUrl)]
        public string? Photo {  get; set; }

        [Display(Name = "Имя")]
        [RegularExpression(@"^[а-яА-Я]*$", ErrorMessage ="Поле не должно содержать цифр/символов")]
        [StringLength(50)]
        [Required(ErrorMessage ="Поле обязательно для заполнения")]
        public required string Name { get; set; }

        [Display(Name = "Фамилия")]
        [RegularExpression(@"^[а-яА-Я]*$", ErrorMessage = "Поле не должно содержать цифр/символов")]
        [StringLength(50)]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public required string Surname { get; set; }

        [Display(Name = "Отчество")]
        [RegularExpression(@"^[а-яА-Я]*$", ErrorMessage = "Поле не должно содержать цифр/символов")]
        [StringLength(50)]
        public string? MiddleName { get; set; }

        [Display(Name = "Серия и номер паспорта")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Поле должно содержать только цифры")]
        [StringLength(10)]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public required string PassportNumSerial { get; set; }

        [Display(Name = "Дата рождения")]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        [DataType(DataType.Date)]
        public required DateTime Birthday { get; set; }

        [Display(Name = "Пол")]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public required GenderType Gender { get; set; }

        [Display(Name = "Адрес")]
        [StringLength(50)]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public required string Address { get; set; }

        [Display(Name = "Номер телефона")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Поле должно содержать только цифры")]
        [StringLength(20)]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        [Phone] 
        public required string PhoneNumber { get; set; }

        [Display(Name = "Электронная почта")]
        [EmailAddress (ErrorMessage = "")]
        [StringLength (320)]
        public string? EmailAddress { get; set; }

        [Display(Name = "Номер медецинской карты")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Поле должно содержать только цифры")]
        [StringLength(7)]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public required string MedCardNum { get; set; }

        [Display(Name = "Дата выдачи мед. карты")]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        [DataType(DataType.Date)]
        public required DateTime MedCardDate { get; set; }

        [Display(Name = "Дата последнего обращения")]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        [DataType(DataType.Date)]
        public required DateTime LastVizitDate { get; set; }

        [Display(Name = "Дата следующего обращения")]
        [DataType(DataType.Date)]
        public DateTime? NextVizitDate { get; set; }

        [Display(Name = "Номер страхового полиса")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Поле должно содержать только цифры")]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        [StringLength(16)]
        public required string PolisNum { get; set; }

        [Display(Name = "Дата окончания полиса")]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        [DataType(DataType.Date)]
        public required DateTime PolisDate { get; set; }

        [Display(Name = "Диагноз")]
        public string? Diagnose { get; set; }

        [Display(Name = "История болезни")]
        public string? MedicalHistory { get; set; }
    }
}
