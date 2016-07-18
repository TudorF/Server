using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Repository.Models
{
    class ClientContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
    }
}
