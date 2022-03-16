using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class TypeEmos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Libelle { get; set; } = "";
        public string Code { get; set; } = "";
        public int? OrdreId { get; set; }
        public Ordre? Ordre { get; set; }
        public ICollection<Emos>? Emos { get; set; }
    }
}