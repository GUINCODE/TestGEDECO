using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class Ordre
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Chrono { get; set; } = "";
        public bool IsActive { get; set; } = true;
        public int? CommandeId { get; set; }
        public Commande? Commande { get; set; }
        public ICollection<Eotp>? Eotps { get; set; }
    }
}