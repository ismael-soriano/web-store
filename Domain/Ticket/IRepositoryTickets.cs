using System.Data.Entity;
using Domain;

namespace Domain
{
    public interface IRepositoryTickets : IUnitOfWork
    {
        IDbSet<Ticket> Invoices { get; set; }
    }
}
