using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Department
    {
        [Key]
        public int DepartmentID { get; set; }
        [StringLength(100)]
        public string DepartmentName { get; set; }
        [StringLength(500)]
        public string DepartmentAddress { get; set; }
        public bool DepartmentStatus { get; set; }
        public DateTime DepartmentCreationDate { get; set; }

        public int FacultyID { get; set; }
        public virtual Faculty Faculty { get; set; }

        public ICollection<User> Users { get; set; }
        public ICollection<Tv> Tvs { get; set; }
    }
}
