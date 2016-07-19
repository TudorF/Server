using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using System.Data.Entity;
using Server.Models;
using Server.Migrations;
using System.Data.Entity.Migrations;

namespace Server
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            //lines to accept return in JSon format.
            //var configuration = new Configuration();
            //var migrator = new DbMigrator(configuration);
            //migrator.Update();

            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<ServerContext, Configuration>());
            
            
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            GlobalConfiguration.Configuration.Formatters.Remove(GlobalConfiguration.Configuration.Formatters.XmlFormatter);
        }
    }
}