using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace KTM_WebTM.THONGTIN
{
    public class tDatabaseInitializer : DropCreateDatabaseAlways<tContext>
    {
        protected override void Seed(tContext context)
        {
            GetTACGIAS().ForEach(c => context.TACGIAS.Add(c));
            GetTINTUCS().ForEach(p => context.TINTUCS.Add(p));
        }
        private static List<TACGIA> GetTACGIAS()
        {
            var tgias = new List<TACGIA> {
new TACGIA
{
TGIA_ID = 1,
TENTG = "A",
EMAIL="ABC"
},
new TACGIA
{
TGIA_ID = 2,
TENTG = "B",
EMAIL="ABC"
},
new TACGIA{
TGIA_ID = 3,
TENTG = "C",
EMAIL="ABC"
},
new TACGIA
{
TGIA_ID = 4,
TENTG = "D",
EMAIL="ABC"
}
};
            return tgias;
        }
        private static List<TINTUC> GetTINTUCS()
        {
            var tintucs = new List<TINTUC> {
    //TINTUC 1
    new TINTUC
{
TIN_ID = 1,
TIEUDE = "The 7 Habits of Highly Effective People",
NOIDUNG = "300 Years Before A Game of Thrones (A Targaryen History)",
NGAYGUI ="2/2/2",
HINHANH="Pic1.png",
TGIA_ID = 1
},
//TINTUC 2
new TINTUC
{
TIN_ID = 2,
TIEUDE = "The 7 Habits of Highly Effective People",
NOIDUNG = "300 Years Before A Game of Thrones (A Targaryen History)",
NGAYGUI ="2/2/2",
HINHANH="Pic1.png",
TGIA_ID = 2
},
//TINTUC 3
new TINTUC
{
TIN_ID = 3,
TIEUDE = "The 7 Habits of Highly Effective People",
NOIDUNG = "300 Years Before A Game of Thrones (A Targaryen History)",
NGAYGUI ="2/2/2",
HINHANH="Pic1.png",
TGIA_ID = 3
},
//TINTUC 4
new TINTUC
{
TIN_ID = 4,
TIEUDE = "The 7 Habits of Highly Effective People",
NOIDUNG = "300 Years Before A Game of Thrones (A Targaryen History)",
NGAYGUI ="2/2/2",
HINHANH="Pic1.png",
TGIA_ID = 4
},

};
            return tintucs;
        }
    }
}