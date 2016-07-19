using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class Field
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Location { get; set; }


        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
