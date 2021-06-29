using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

using NTT.MyTable;

namespace NTT.DataAccess.Delete
{
    public class XoaDuLieuGioHang
    {
        private GioHang _giohang;
        public XoaDuLieuGioHang() { } //
        public GioHang Giohang
        {
            get { return _giohang; }
            set { _giohang = value; }
        }
        public void xoadulieu()
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoi chuoiketnoi = new KetNoi();
            sqldata.ConnectionString = chuoiketnoi.ConnectionString();
            sqldata.DeleteCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.DeleteCommand = "GioHang_Delete";
            sqldata.DeleteParameters.Add("IDGioHang", Giohang.IdGioHang.ToString());
            sqldata.Delete();
        }
    }



}