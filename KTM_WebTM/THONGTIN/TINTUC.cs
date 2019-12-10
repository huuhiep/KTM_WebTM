using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KTM_WebTM.THONGTIN
{
    public class TINTUC
    {[Key]

        [ScaffoldColumn(false)]
        public int TIN_ID { get; set; }
        [Required, StringLength(100), Display(Name = "TIEU DE")]
        public string TIEUDE { get; set; }

        [Required, StringLength(1000), Display(Name = "NOI DUNG"),
        DataType(DataType.MultilineText)]
        public string NOIDUNG { get; set; }
        [Required, StringLength(20), Display(Name = "NGAY GUI")]
        public string NGAYGUI { get; set; }
        public string HINHANH { get; set; }

        public int? TGIA_ID { get; set; }
        public virtual TACGIA TACGIA { get; set; }
    }
}