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
    public class ProductService : IProductService
    {
        readonly IRepositoryProducts _repository;
        public ProductService(IRepositoryProducts repository)
        {
            Check.NotNull(repository, "repository");
            _repository = repository;
        }

        public IEnumerable<Product> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
