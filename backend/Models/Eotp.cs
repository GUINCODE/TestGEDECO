using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class Eotp
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Libelle { get; set; } = "";
        public int? OrdreId { get; set; }
        public Ordre? Ordre { get; set; }
        public bool IsActive { get; set; } = true;
        public ICollection<BudgetEotp>? Budgets { get; set; }
        public ICollection<FicheIntervention>? FicheInterventions { get; set; }
        public ICollection<Poste>? Postes { get; set; }
        // public ICollection<Emos>? Emos { get; set; }
    }
}