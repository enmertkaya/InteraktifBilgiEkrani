using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class New
    {
        [Key]
        public int NewID { get; set; }
        [StringLength(100)]
        public string NewName { get; set; }
        [StringLength(500)]
        public string NewPath { get; set; }
        [StringLength(500)]
        public string NewDescription { get; set; }
        public bool NewStatus { get; set; }
        public DateTime NewCreationDate { get; set; }


        public int UserID { get; set; }
        public virtual User User { get; set; }

        public int TvID { get; set; }
        public virtual Tv Tv { get; set; }
    }
}
