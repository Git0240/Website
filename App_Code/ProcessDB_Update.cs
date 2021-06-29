using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NTT.DataAccess.Update;

namespace NTT.ProcessDB.Update
{
    public class CapNhatThongKeTruyCap
    {
        public CapNhatThongKeTruyCap() { }
        public void Thucthi()
        {
            CapNhatDuLieuThongKeTruyCap dulieuthongketruycap = new CapNhatDuLieuThongKeTruyCap();
            dulieuthongketruycap.Capnhatdulieu();
        }
    }
}