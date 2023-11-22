using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KurumsalWeb.Models.Model
{
    public class New
    {
        [Key]
        public int NewID { get; set; }
        [StringLength(30,ErrorMessage ="30 karakter olmalıdır")]
        [DisplayName("Haber İsmi")]
        public string NewName { get; set; }
        [StringLength(500)]
        [DisplayName("Haber Resmi")]
        public string NewPath { get; set; }
        
        [StringLength(500, ErrorMessage = "500 karakterden az olmalıdır")]
        [DisplayName("Haber Açıklama")]
        public string NewDescription { get; set; }
        [DisplayName("Açıklama Sol Üst")]
        public string NewDescription1 { get; set; }
     


        public int UserID { get; set; }
        public virtual User User { get; set; }

        public int TvID { get; set; }
        public virtual Tv Tv { get; set; }
    }
}