using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Domain;
using Core.Utils;

namespace WebStoreWcf
{
    public class TicketService : ServiceBase, ITicketService
    {
        readonly IRepositoryTickets _repository;
        public TicketService(IRepositoryTickets repository) : base(repository)
        {
            Check.NotNull(repository, "repository");
            /*if (null == repository)
            {
                throw new ArgumentNullException("repository");
            }*/

            _repository = repository;
        }

        public Ticket Add(Ticket invoice)
        {
            var customerNew = _repository.Invoices.Add(invoice);
            SaveChanges();
            return customerNew;
        }

        public Ticket Update(int id, Ticket invoice)
        {
            var oldInvoice = Get(id);
            if (null == oldInvoice)
            {
                throw new NullReferenceException("The invoice can't be null");
            }
            oldInvoice.Operations = invoice.Operations;
            SaveChanges();
            return oldInvoice;
        }

        public Ticket Delete(int id)
        {
            var invoice = Get(id);
            _repository.Invoices.Remove(invoice);
            SaveChanges();
            return invoice;
        }

        public IEnumerable<Ticket> GetAll()
        {
            return _repository.Invoices.ToList();
        }

        public Ticket Get(int id)
        {
            return _repository.Invoices.Where(c => c.Id == id).FirstOrDefault();
        }
    }
}
