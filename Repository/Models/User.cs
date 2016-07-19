using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class User
    {

        public int ID { get; set; }
        public String Name { get; set; }
        public String Password { get; set; }

        public String Status { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }

    }
}
