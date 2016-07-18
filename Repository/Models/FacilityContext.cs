using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Repository.Models
{
    class FacilityContext : DbContext
    {
        public FacilityContext() : base("FacilityContext")
        {}
            public DbSet<Client> Clients { get; set; }
            public DbSet<Field> Fields { get; set; }
    }
}

