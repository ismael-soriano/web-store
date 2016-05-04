using Core;
using Domain.Ticket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    class RepositoryTicket : RepositoryBase<Ticket>, IRepositoryTicket
    {
        public RepositoryTicket(IDbBase context) : base(context)
        {

        }

        public Ticket Add(Ticket ticket)
        {
            throw new NotImplementedException();
        }

        public Ticket Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Ticket> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
