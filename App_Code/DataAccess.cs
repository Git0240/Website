using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;


namespace NTT.DataAccess 
{
    public class KetNoi
    {
        public KetNoi() { }

        public string ConnectionString()
        {
            return WebConfigurationManager.ConnectionStrings["SQLCONN"].ConnectionString;
            //Tra ve chuoi ket noi voi sql server cua bien SQLCONN. SQLCONN la ten do ta dat trong WebConfig.
        }
    }
}