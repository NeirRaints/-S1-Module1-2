using ClinicBigBoarsWeb.Data.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicBigBoarsWeb.Models
{
    public class Hospitalization
    {
        [Key]
        public int HospitalizationId { get; set; }
        [ForeignKey(nameof(Patient))]
        [Display(Name = "Код Пациента")]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public required int PatientId { get; set; }
        [ForeignKey(nameof(HospitalizationCode))]
        [Display(Name = "Код госпиталицазии")]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public required int HospitalizationCode { get; set; }
        [DataType(DataType.DateTime)]
        [Display(Name = "Назначенное дата и время")]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public required DateTime AppointedDate { get; set; }
        [Display(Name = "Цель госпитализации")]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public required string HospitalizationObj { get; set; }
        [Display(Name = "Отделение")]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public required string Department { get; set; }
        [Display(Name = "Условия")]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public required ConditionsType Conditions { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Сроки")]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public required DateTime DeadlineDate { get; set; }
        [Display(Name = "Дополнительно")]
        public string? Additionally {  get; set; }
    }
}
