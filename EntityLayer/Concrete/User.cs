using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
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
        [StringLength(11)]
        public string UserPhone { get; set; }
        [StringLength(75)]
        public string UserMail { get; set; }
        public string UserPath { get; set; }
        public bool UserStatus { get; set; }
        public DateTime UserCreationDate { get; set; }


        [ForeignKey(nameof(Role))]
        public int Permission { get; set; }
        public virtual Role Role { get; set; }


        public int DepartmentID { get; set; }
        public virtual Department Department { get; set; }

        public int? FacultyID { get; set; }
        public virtual Faculty Faculty { get; set; }


        public ICollection<New> News { get; set; }
    }
}
