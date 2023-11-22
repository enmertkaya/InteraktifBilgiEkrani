using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KurumsalWeb.Models.Model
{
    public class User 
    {
        [Key]
        public int UserID { get; set; }
        [StringLength(50)]
      
        public string UserName { get; set; }
        [StringLength(50)]
        
        public string UserSurname { get; set; }
        [StringLength(50)]
        
        public string UserPassword { get; set; }
       
        [StringLength(50)]
        public string UserMail { get; set; }
        public string UserPath { get; set; }

        public int? RoleID { get; set; }
        public virtual Role Role { get; set; }

        public int? FacultyID { get; set; }
        public virtual Faculty Faculty { get; set; }
        public int? DepartmentID { get; set; }
        public virtual Department Department { get; set; }

        public ICollection<New> News { get; set; }
      
    }
}