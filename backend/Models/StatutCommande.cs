using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class StatutCommande
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Libelle { get; set; }
        public bool? IsActive { get; set; } = true;
        public ICollection<Commande>? Commandes { get; set; }
    }
}