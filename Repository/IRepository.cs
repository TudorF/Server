using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    interface IRepository<T> where T:class
    {
        IEnumerable<T> GetAll();
        T GetClient(int id);
        void Add(T client);
 

    }
}
