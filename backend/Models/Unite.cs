using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class Unite
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Code { get; set; }
        public string? Libelle { get; set; }
        public bool IsActif { get; set; } = true;
        public int? CodePostale { get; set; }
        [MaxLength(50)]
        public string? Ville { get; set; }
        [MaxLength(50)]
        public string? Region { get; set; }
        [MaxLength(10)]
        public string? Telephone { get; set; }
        [MaxLength(20)]
        public string? Fax { get; set; }
        [MaxLength(20)]
        public string? Email { get; set; }
        [MaxLength(50)]
        public string? Direction { get; set; }
        public string? Departement { get; set; }
        [MaxLength(50)]
        public string? Service { get; set; }
        [MaxLength(50)]
        public string? Bureau { get; set; }
        public ICollection<Habilitation>? Habilitations { get; set; }
    }
}