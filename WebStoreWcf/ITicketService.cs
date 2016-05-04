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
    public interface ITicketService
    {
        [OperationContract]
        Ticket Add(Ticket invoice);

        [OperationContract]
        Ticket Update(int id, Ticket invoice);

        [OperationContract]
        Ticket Delete(int id);

        [OperationContract]
        IEnumerable<Ticket> GetAll();

        [OperationContract]
        Ticket Get(int id);
    }
}
