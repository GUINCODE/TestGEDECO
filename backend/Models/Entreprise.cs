using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class Entreprise
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(255)]
        public string? Nom { get; set; }
        public string? Siren { get; set; }
        public string? Telephone { get; set; }
        public string? Fax { get; set; }
        public string? Mail { get; set; }
        public ICollection<AdresseEntreprise>? Adresses { get; set; }
        public ICollection<Contact>? Contacts { get; set; }
        public ICollection<Commande>? Commandes { get; set; }
    }
}