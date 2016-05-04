using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Core;
using Core.Utils;
using Domain.Ticket;

namespace WebStoreWcf
{
    public class TicketService : ServiceBase, ITicketService
    {
        readonly IRepositoryTicket _repository;
        readonly IUnitOfWork _unitOfWork;
        public TicketService(IRepositoryTicket repository, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            Check.NotNull(repository, "repository");
            Check.NotNull(unitOfWork, "unitOfWork");
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public Ticket Add(Ticket ticket)
        {
            foreach (var item in ticket.TicketDetails)
            {
                item.Price = item.Product.Price;
            }

            var customerNew = _repository.Add(ticket);
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
            oldInvoice.TicketDetails = invoice.TicketDetails;
            SaveChanges();
            return oldInvoice;
        }

        public Ticket Delete(int id)
        {
            var invoice = Get(id);
            _repository.Remove(invoice);
            SaveChanges();
            return invoice;
        }

        public IEnumerable<Ticket> GetAll()
        {
            return _repository.GetAll().ToList();
        }

        public Ticket Get(int id)
        {
            return _repository.Get(id);
        }
    }
}
