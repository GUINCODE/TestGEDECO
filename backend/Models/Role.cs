using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using backend.Models.ManyToMany;

namespace backend.Models
{
    public class Role
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Libelle { get; set; } = "";
        public bool IsActive { get; set; } = true;
        public ICollection<RoleDroit>? RoleDroits { get; set; }
        public ICollection<Habilitation>? Habilitations { get; set; }
    }
}