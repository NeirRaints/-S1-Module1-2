using System.ComponentModel.DataAnnotations;

namespace ClinicBigBoarsWeb.Models
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }
        public string? Photo {  get; set; }
        public required string Name { get; set; }
        public required string Surname { get; set; }
        public string? MiddleName { get; set; }
        public required string PassportNumSerial { get; set; }
        [DataType(DataType.Date)]
        public required DateTime Birthday { get; set; }
        [Phone] 
        public required string PhoneNumber { get; set; }
        [EmailAddress]
        public required string EmailAddress { get; set; }
        public required string MedCardNum { get; set; }
        [DataType(DataType.Date)]
        public required DateTime MedCardDate { get; set; }
        [DataType(DataType.Date)]
        public required DateTime LatVizitDate { get; set; }
        [DataType(DataType.Date)]
        public required DateTime NextVizitDate { get; set; }
        public required string PolisNum { get; set; }
        [DataType(DataType.Date)]
        public required DateTime PolisDate { get; set; }
        public string? Diagnose { get; set; }
        public string? MedicalHistory { get; set; }


    }
}
