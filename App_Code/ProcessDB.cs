using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NTT.ProcessDB
{
    public class TaoCartGUID
    {
        public static string LayCartGUID()
        {
            if (HttpContext.Current.Request.Cookies["DIENTHOAI"] != null)
            {
                return HttpContext.Current.Request.Cookies["DIENTHOAI"]["CartID"].ToString();
            }
            else
            {
                Guid CartGUID = Guid.NewGuid();
                HttpCookie cookie = new HttpCookie("DIENTHOAI");
                cookie.Values.Add("CartID", CartGUID.ToString());
                cookie.Expires = DateTime.Now.AddDays(30);
                HttpContext.Current.Response.AppendCookie(cookie);
                return CartGUID.ToString();
            }
        }
    }
}