using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_CodeFirst_Core.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public int? RoleId { get; set; }

        [StringLength(20)]
        public string UserName { get; set; }

        [StringLength(20)]
        public string Password { get; set; }

        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }
    }
}
