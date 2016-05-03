using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Domain;

namespace WebStoreWcf
{
    public class InvoiceService : ServiceBase, IInvoiceService
    {
        readonly IRepositoryInvoices _repository;
        public InvoiceService(IRepositoryInvoices repository) : base(repository)
        {
            if (null == repository)
            {
                throw new ArgumentNullException("repository");
            }

            _repository = repository;
        }

        public Invoice Add(Invoice invoice)
        {
            var customerNew = _repository.Invoices.Add(invoice);
            SaveChanges();
            return customerNew;
        }

        public Invoice Update(int id, Invoice invoice)
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

        public Invoice Delete(int id)
        {
            var invoice = Get(id);
            _repository.Invoices.Remove(invoice);
            SaveChanges();
            return invoice;
        }

        public IEnumerable<Invoice> GetAll()
        {
            return _repository.Invoices.ToList();
        }

        public Invoice Get(int id)
        {
            return _repository.Invoices.Where(c => c.Id == id).FirstOrDefault();
        }
    }
}
