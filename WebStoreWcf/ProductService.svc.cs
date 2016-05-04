using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Core;
using Core.Utils;
using Domain.Product;

namespace WebStoreWcf
{
    public class ProductService : ServiceBase, IProductService
    {
        readonly IRepositoryProduct _repository;
        readonly IUnitOfWork _unitOfWork;
        public ProductService(IRepositoryProduct repository, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            Check.NotNull(repository, "repository");
            Check.NotNull(unitOfWork, "unitOfWork");
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Product> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
