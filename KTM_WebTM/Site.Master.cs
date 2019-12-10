using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KTM_WebTM.THONGTIN;

namespace KTM_WebTM
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<TACGIA> GetCategories()
        {
            var _db = new KTM_WebTM.THONGTIN.tContext();
            IQueryable<TACGIA> query = _db.TACGIAS;
            return query;
        }
    }
}