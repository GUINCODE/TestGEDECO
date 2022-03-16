using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class ValidationEmos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? EmosId { get; set; }
        public Emos? Emos { get; set; }
        public int? TypeValidationEmosId { get; set; }
        public TypeValidationEmos? TypeValidationEmos { get; set; }
        public int? ValideurId { get; set; }
        public Personnel? Valideur { get; set; }
        public DateTime? DateValidation { get; set; }

    }
}