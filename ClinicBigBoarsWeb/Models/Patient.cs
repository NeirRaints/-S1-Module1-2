using System.ComponentModel.DataAnnotations;

namespace ClinicBigBoarsWeb.Models
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }
        public string? Photo {  get; set; }
        [StringLength(50)]
        public required string Name { get; set; }
        [StringLength(50)]
        public required string Surname { get; set; }
        [StringLength(50)]
        public string? MiddleName { get; set; }
        [StringLength(10)]
        public required string PassportNumSerial { get; set; }
        [DataType(DataType.Date)]
        public required DateTime Birthday { get; set; }
        [StringLength(20)]
        [Phone] 
        public required string PhoneNumber { get; set; }
        [EmailAddress]
        public required string EmailAddress { get; set; }
        [StringLength(7)]
        public required string MedCardNum { get; set; }
        [DataType(DataType.Date)]
        public required DateTime MedCardDate { get; set; }
        [DataType(DataType.Date)]
        public required DateTime LatVizitDate { get; set; }
        [DataType(DataType.Date)]
        public required DateTime NextVizitDate { get; set; }
        [StringLength(16)]
        public required string PolisNum { get; set; }
        [DataType(DataType.Date)]
        public required DateTime PolisDate { get; set; }
        public string? Diagnose { get; set; }
        public string? MedicalHistory { get; set; }
    }
}
