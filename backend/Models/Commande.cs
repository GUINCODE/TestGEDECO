using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using backend.Models.ManyToMany;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace backend.Models
{
    public class Commande
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? NumCommnade { get; set; }
        public string? Libelle { get; set; }
        [MaxLength(50)]
        public string? NomCourt { get; set; }
        public decimal MontantTotal { get; set; }
        public decimal MontantAnnuelEstimer { get; set; }
        public decimal SeuilEMOS_Specifique { get; set; }
        public DateTime? DateDebut { get; set; }
        public DateTime? DateFin { get; set; }
        public int NombreMois { get; set; }
        public string? Commentaire { get; set; }
        public int? StatutCommandeId { get; set; }
        public StatutCommande? StatutCommande { get; set; }
        public int? EntrepriseId { get; set; }
        public Entreprise? Entreprise { get; set; }
        public int? AcheteurId { get; set; }
        public Personnel? Acheteur { get; set; }
        public ICollection<CommandePoste>? CommandePostes { get; set; }
        public ICollection<Document>? Documents { get; set; }
        public ICollection<Emos>? Emos { get; set; }
        public ICollection<Ordre>? Ordres { get; set; }
        public ICollection<FicheIntervention>? FicheInterventions { get; set; }
    }
}