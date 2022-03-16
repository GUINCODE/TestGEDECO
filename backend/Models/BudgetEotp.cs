using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class BudgetEotp
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Annee { get; set; }
        public double? BudgetInitiale { get; set; }
        public double? BudgetPrevisionnel { get; set; }
        public double? Budgetrevise1 { get; set; }
        public double? Budgetrevise2 { get; set; }
        public double? Budgetrevise3 { get; set; }
        public int? EotpId { get; set; }
        public Eotp? Eotp { get; set; }
    }
}