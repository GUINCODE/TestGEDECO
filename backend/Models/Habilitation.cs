using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class Habilitation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? RoleId { get; set; }
        public Role? Role { get; set; }
        public int? UniteId { get; set; }
        public Unite? Unite { get; set; }
        public int? Personnelid { get; set; }
        public Personnel?  Personnel { get; set; }
    }
}