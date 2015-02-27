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
            switch (System.Net.Dns.GetHostName())
            {
                case "":
                    return ConfigurationManager.ConnectionStrings["DefaultCloudStage"].ConnectionString;
                case "test":
                    return ConfigurationManager.ConnectionStrings["DefaultLocalDev"].ConnectionString;
                default:
                    return ConfigurationManager.ConnectionStrings["DefaultCloudStage"].ConnectionString;
            }

        }
    }
}