using System.Collections.Generic;
using System.Data.Entity;
using Core;

namespace Domain.Product
{
    public interface IRepositoryProduct
    {
        IEnumerable<Product> GetAll();
    }
}
