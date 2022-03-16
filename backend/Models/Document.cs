using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class Document
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Titre { get; set; }
        public string? Commentaire { get; set; }
        public byte[]? AttachmentId { get; set; }
        public int? CommandeId { get; set; }
        public Commande? Commande { get; set; }
    }
}