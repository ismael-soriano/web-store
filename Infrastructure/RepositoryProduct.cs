using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Data.Entity;

namespace Infrastructure
{
    public class RepositoryProduct : RepositoryBase, IRepositoryProducts
    {
        readonly IDbSet<Product> Products;
        public RepositoryProduct(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            Products = Set<Product>();
        }

        public IEnumerable<Product> GetAll()
        {
            return Products.Select(c => c);
        }
    }
}
