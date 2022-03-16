using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class ValidationFi
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? TypeValidationId { get; set; }
        public TypeValidationFi? TypeValidation { get; set; }
        public int? FicheInterventionId { get; set; }
        public FicheIntervention? FicheIntervention { get; set; }
        public int? ValideurId { get; set; }
        public Personnel? Valideur { get; set; }
        public DateTime? DateValidation { get; set; }
    }
}