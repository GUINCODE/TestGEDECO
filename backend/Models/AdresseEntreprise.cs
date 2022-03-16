using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class AdresseEntreprise
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }
        public string? Adresse { get; set; }
        public int? CondePostale { get; set; }
        public string? Ville { get; set; }
        public int? EntrepriseId { get; set; }
        public Entreprise? Entreprise { get; set; }
    }
}