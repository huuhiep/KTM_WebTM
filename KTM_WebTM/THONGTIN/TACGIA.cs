using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KTM_WebTM.THONGTIN
{
    public class TACGIA
    {
        [Key]
        [ScaffoldColumn(false)]
        public int TGIA_ID { get; set; }
        [Required, StringLength(100), Display(Name = "TEN TAC GIA")]
        public string TENTG { get; set; }
        [Required, StringLength(100), Display(Name = "EMAIL")]
        public string EMAIL { get; set; }
        public virtual ICollection<TINTUC> TINTUCS { get; set; }
    }
}