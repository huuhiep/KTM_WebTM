using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.ModelBinding;
using KTM_WebTM.THONGTIN;

namespace KTM_WebTM
{
    public partial class tList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<TINTUC> GetBooks([QueryString("id")] int? categoryId)
        {
            var _db = new KTM_WebTM.THONGTIN.tContext();
            IQueryable<TINTUC> query = _db.TINTUCS;
            if (categoryId.HasValue && categoryId > 0)
            {
                query = query.Where(p => p.TGIA_ID == categoryId);
            }
            return query;
        }
    }
}