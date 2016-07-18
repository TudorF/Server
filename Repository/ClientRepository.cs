using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Models;

namespace Repository
{
    class ClientRepository:IRepository<Client>,IDisposable
    {
        private ClientContext context;
        ClientRepository(ClientContext context)
        {
            this.context = context;
        }
        

       
        public IEnumerable<Client> GetAll()
        {
            return context.Clients.ToList();
        }

        public Client GetClient(int id)
        {
            return context.Clients.Find(id);
        }

        public void Add(Client client)
        {
            context.Clients.Add(client);
        }

       

       
        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

