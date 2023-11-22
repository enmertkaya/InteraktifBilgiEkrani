using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Tv
    {
        [Key]
        public int TvID { get; set; }
        [StringLength(500)]
        public string TvDescription { get; set; }
        [StringLength(500)]
        public string TvAddress { get; set; }
        public DateTime TvCreationDate { get; set; }
        public bool TvStatus { get; set; }

        public int? DepartmentID { get; set; }
        public virtual Department Department { get; set; }

        public ICollection<New> News { get; set; }
    }
}
