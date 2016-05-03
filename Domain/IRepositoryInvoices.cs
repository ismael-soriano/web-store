using System.Data.Entity;

namespace Domain
{
    public interface IRepositoryInvoices : IUnitOfWork
    {
        IDbSet<Invoice> Invoices { get; set; }
    }
}
