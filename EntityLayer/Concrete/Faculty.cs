using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Faculty
    {
        [Key]
        public int FacultyID { get; set; }
        [StringLength(100)]
        public string FacultyName { get; set; }
        [StringLength(500)]
        public string FacultyAddress { get; set; }
        public bool FacultyStatus { get; set; }
        public DateTime FacultyCreationDate { get; set; }


        public ICollection<User> Users { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}
