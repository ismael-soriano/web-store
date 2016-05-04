using System.Data.Entity;
using Core;
using System.Collections;
using System.Collections.Generic;

namespace Domain.Ticket
{
    public interface IRepositoryTicket
    {
        Ticket Add(Ticket ticket);
        Ticket Get(int id);
        IEnumerable<Ticket> GetAll();
    }
}
