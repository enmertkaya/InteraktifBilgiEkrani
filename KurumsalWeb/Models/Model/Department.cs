using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KurumsalWeb.Models.Model
{
    public class Department
    {
        [Key]
        public int DepartmentID { get; set; }
        [StringLength(50)]
        [DisplayName("Bölüm İsmi")]
        public string DepartmentName { get; set; }
        [StringLength(500)]
        [DisplayName("Bölüm Adresi")]
        public string DepartmentAddress { get; set; }
        public bool DepartmentStatus { get; set; }
        [DisplayName("Tarih")]
        public DateTime DepartmentCreationDate { get; set; }

        public int FacultyID { get; set; }
        public virtual Faculty Faculty { get; set; }

        public ICollection<User> Users { get; set; }
        public ICollection<Tv> Tvs { get; set; }
    }
}