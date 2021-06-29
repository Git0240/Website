using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using NTT.MyTable;
using NTT.DataAccess.Insert;

namespace NTT.ProcessDB.Insert 
{
    public class Process_ThemGioHang
    {
        private GioHang _giohang;
        public GioHang Giohang
        {
            get { return _giohang; }
            set { _giohang = value; }
        }
        public void Thucthi()
        {
            ThemDuLieuGioHang dulieugiohang = new ThemDuLieuGioHang();
            dulieugiohang.Giohang = this.Giohang;
            dulieugiohang.Themdulieugiohang();
        }
    }
}