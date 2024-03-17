using ClinicBigBoarsWeb.Data.Enum;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicBigBoarsWeb.Models
{
    public class Hospitalization
    {
        [Key]
        public int HospitalizationId { get; set; }

        [ForeignKey(nameof(PatientId))]
        [Display(Name = "Код Пациента")]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public int PatientId { get; set; }

        [ForeignKey(nameof(HospitalizationCode))]
        [Display(Name = "Код госпитализации")]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public int HospitalizationCode { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Назначенное дата и время")]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime AppointedDate { get; set; }

        [Display(Name = "Цель госпитализации")]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public required string HospitalizationObj { get; set; }

        [Display(Name = "Отделение")]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public required string Department { get; set; }

        [Display(Name = "Условия")]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public ConditionsType Conditions { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Сроки")]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public DateTime DeadlineDate { get; set; }

        [Display(Name = "Дополнительно")]
        public string? Additionally { get; set; }
    }
}
