﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Server.Migrations;

namespace Server.Models
{
    public class ServerContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public ServerContext() : base("name=ServerContext")
        {
            //this.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<ServerContext, Configuration>());
        }

        public System.Data.Entity.DbSet<Repository.Models.User> Users { get; set; }
        public System.Data.Entity.DbSet<Repository.Models.Field> Fields { get; set; }
        public System.Data.Entity.DbSet<Repository.Models.Reservation> Reservations { get; set; }
    }
}
