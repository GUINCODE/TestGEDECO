using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using backend.Models.ManyToMany;

namespace backend.Models
{
    public class Poste
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public double MontantInitiale { get; set; }
        public double MontantEngage { get; set; }
        public double MontantRestant { get; set; }
        public bool IsForfait { get; set; } = false;
        public bool IsCloture { get; set; } = false;
        public int? EotpId { get; set; }
        public Eotp? Eotp { get; set; }
        public int? EmosId { get; set; }
        public Emos? Emos { get; set; }
        public ICollection<CommandePoste>? CommandePostes { get; set; }
    }
}