using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebStoreWcf
{
    [ServiceContract]
    public interface IInvoiceService
    {
        [OperationContract]
        Invoice Add(Invoice invoice);

        [OperationContract]
        Invoice Update(int id, Invoice invoice);

        [OperationContract]
        Invoice Delete(int id);

        [OperationContract]
        IEnumerable<Invoice> GetAll();

        [OperationContract]
        Invoice Get(int id);
    }
}
