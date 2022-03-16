using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class FicheIntervention
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Numero { get; set; } = "";
        public string Installation { get; set; } = "";
        public DateTime DateCreation { get; set; }
        public DateTime? DateDevis { get; set; }
        public DateTime? DateFinTravaux { get; set; }
        public DateTime? DateCloture { get; set; }
        public double? Montant { get; set; }
        public string? Description { get; set; }
        public string? Regularisation { get; set; }
        public int? EotpId { get; set; }
        public Eotp? Eotp { get; set; }
        public int? EmosId { get; set; }
        public Emos? Emos { get; set; }
        public int? CommandeId { get; set; }
        public Commande? Commande { get; set; }
        public int? DemandeurId { get; set; }
        public Personnel? Demandeur { get; set; }
        public int? OrdreId { get; set; }
        public Ordre? Ordre { get; set; }
        public int? StatusFiId { get; set; }
        public StatutFi? StatusFi { get; set; }
        public ICollection<ValidationFi>? ValidationFis { get; set; }
    }
}