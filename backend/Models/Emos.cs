using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class Emos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Numero { get; set; }
        public double MontantInitiale { get; set; }
        public double Montant { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsAvancement { get; set; } = false;
        public double Avancement { get; set; }
        public bool IsEmisEM { get; set; } = false;
        public DateTime? DateEmisEM { get; set; }
        public bool IsHorsForfait { get; set; } = false;
        public bool IsCancel { get; set; } = false;
        public bool IsWorkflowSuccessuful { get; set; } = false;
        public bool IsActive { get; set; } = true;
        public int? TypeEmosId { get; set; }
        public TypeEmos?  TypeEmos { get; set; }
        public int? CommandeId { get; set; }
        public Commande? Commande { get; set; }
        public int? CreerParId { get; set; }
        public Personnel? CreerPar { get; set; }
        public int? EotpId { get; set; }
        public Eotp? Eotp { get; set; }
        public ICollection<Poste>? Postes { get; set; }
        public ICollection<FicheIntervention>? FicheInterventions { get; set; }
        public ICollection<ValidationEmos>? ValidationEmos { get; set; }
    }
}