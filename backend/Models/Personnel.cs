using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class Personnel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Nom { get; set; }
        public string? Prenom { get; set; }
        public string? Matricule { get; set; }
        public string? Login { get; set; }
        public string? UltimusResp { get; set; }
        public bool? IsActive { get; set; } = true;
        public int? ResponsableId { get; set; }
        public Personnel? Responsable { get; set; }
        public ICollection<Habilitation>? Habilitations { get; set; }
        public ICollection<Commande>? Commandes { get; set; }
        public ICollection<FicheIntervention>? FicheInterventions { get; set; }
        public ICollection<ValidationFi>? ValidationFis { get; set; }
        public ICollection<ValidationEmos>? ValidationEmos { get; set; }
        public ICollection<Emos>? Emos { get; set; }
    }
}