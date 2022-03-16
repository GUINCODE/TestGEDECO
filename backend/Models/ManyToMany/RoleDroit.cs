using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models.ManyToMany
{
    public class RoleDroit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? RoleId { get; set; }
        public Role? Role { get; set; }
        public int? DroitId { get; set; }
        public Droit? Droit { get; set; }
        public bool? IsActive { get; set; } = true;
    }
}