using System.Collections.Generic;
using System.Data.Entity;
using Core;

namespace Domain
{
    public interface IRepositoryProducts : IUnitOfWork
    {
        IEnumerable<Product> GetAll();
    }
}
