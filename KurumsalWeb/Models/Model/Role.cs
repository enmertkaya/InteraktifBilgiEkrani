using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KurumsalWeb.Models.Model
{
    public class Role
    {
        [Key]
        public int RoleID { get; set; }
        [StringLength(20)]
        [DisplayName("Rol İsmi")]
        public string RoleName { get; set; }
        [StringLength(10)]
        [DisplayName("Rol Kısaltma")]
        public string RoleShortName { get; set; }
        [StringLength(500)]
        [DisplayName("Açıklama")]
        public string RoleDescription { get; set; }
        public bool RoleStatus { get; set; }
        
        public DateTime RoleCreationDate { get; set; }

        public ICollection<User> Users { get; set; }
    }
}