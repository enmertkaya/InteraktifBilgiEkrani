using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Role
    {
        [Key]
        public int RoleID { get; set; }
        [StringLength(50)]
        public string RoleName { get; set; }
        [StringLength(10)]
        public string RoleShortName { get; set; }
        [StringLength(500)]
        public string RoleDescription { get; set; }
        public bool RoleStatus { get; set; }
        public DateTime RoleCreationDate { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
