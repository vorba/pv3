using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Purevision.Web.Helpers
{
    public class ConnectionStringHelpers
    {
        public static string GetHostBasedConnectionString()
        {
            return GetConnectionStringByName(GetHostBasedConnectiongStringName());
        }

        public static string GetHostBasedConnectiongStringName()
        {
            switch (System.Net.Dns.GetHostName())
            {
                case "vorba": return "local";       // Local Dev
                case "ip-0AB73585": return "cloud"; // AppHarbor
                default: return "cloud";
                   
            }           
        }

        public static string GetConnectionStringByName(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}