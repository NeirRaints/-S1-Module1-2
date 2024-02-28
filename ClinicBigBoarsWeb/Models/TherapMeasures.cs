using ClinicBigBoarsWeb.Data.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace ClinicBigBoarsWeb.Models
{
    public class TherapMeasures
    {
        [Key]
        public int MeasureId { get; set; }
        [ForeignKey(nameof(Patient))]
        public required int PatientId { get; set; }
        [DataType(DataType.Date)] 
        public DateTime EventDate { get; set; }
        [StringLength(50)]
        public required string Doctor { get; set; }
        public required string Event { get; set; }
        [StringLength(50)]
        public required string EventName { get; set; }
        public required string Results { get; set; }
        public required string Recomendations { get; set; }

    }
}
