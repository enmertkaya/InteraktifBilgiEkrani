using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KurumsalWeb.Models.Model
{
    public class Faculty
    {
        [Key]
        public int FacultyID { get; set; }

        [StringLength(100)]
        [DisplayName("Fakülte İsmi")]
        public string FacultyName { get; set; }

        [StringLength(500)]
        [DisplayName("Fakülte Adresi")]
        public string FacultyAddress { get; set; }
        public bool FacultyStatus { get; set; }
        [DisplayName("Tarih")]
        public DateTime FacultyCreationDate { get; set; }


        public ICollection<User> Users { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}