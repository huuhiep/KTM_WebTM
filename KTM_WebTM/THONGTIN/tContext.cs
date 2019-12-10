using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KTM_WebTM.THONGTIN
{
    public class tContext : DbContext
    {
      
            public tContext() : base("THONGTIN")
            { }
            public DbSet<TACGIA> TACGIAS { get; set; }
            public DbSet<TINTUC> TINTUCS { get; set; }
        
    }
}