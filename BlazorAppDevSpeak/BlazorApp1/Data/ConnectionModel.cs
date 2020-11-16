using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class ConnectionModel
    {
        public static string strConn = "Server=tcp:youraccount.database.windows.net,1433;Initial Catalog=SSISDB;Persist Security Info=False;User ID=username; " +
                "Password=password;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
    }
}
