using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models.ManyToMany
{
    public class CommandePoste
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? CommandeId { get; set; }
        public Commande? Commande { get; set; }
        public int? PosteId { get; set; }
        public Poste? Poste { get; set; }
    }
}