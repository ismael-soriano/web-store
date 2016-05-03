using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Web;
using Domain;

namespace WebStoreWcf
{
    [ServiceContract]
    public interface IInvoiceService
    {
        [OperationContract]
        IEnumerable<Invoice> GetAll();

        [OperationContract]
        string Get(int id);

        [OperationContract]
        string Add(Invoice invoice);

        [OperationContract]
        string Update(int id, Invoice invoice);

        [OperationContract]
        string Delete(int id);
    }
}
