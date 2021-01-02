using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EF_CodeFirst_Core.Models
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }

        [StringLength(20)]
        public string RoleName { get; set; }
    }
}
