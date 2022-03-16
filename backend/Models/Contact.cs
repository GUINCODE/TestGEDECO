using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class Contact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Nom { get; set; }
        public string? Prenom { get; set; }
        public string? TelephonePro { get; set; }
        public string? MailPro { get; set; }
        public bool? IsDefault { get; set; } = false;
        public int? EntrepriseId { get; set; }
        public Entreprise? Entreprise { get; set; }
    }
}