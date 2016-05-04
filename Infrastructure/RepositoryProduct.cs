using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using System.Data.Entity;
using Domain.Product;
using Core.Utils;

namespace Infrastructure
{
    public class RepositoryProduct : RepositoryBase<Domain.Product.Product>, IRepositoryProduct
    {
        public RepositoryProduct(IDbBase context) : base(context) { }

        public IEnumerable<Product> GetAll()
        {
            return Entity.Select(c => c);
        }

    }
}
