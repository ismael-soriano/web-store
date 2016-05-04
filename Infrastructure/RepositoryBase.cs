using Core.Utils;
using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class RepositoryBase
    {
        readonly IUnitOfWork _unitOfWork;
        public RepositoryBase(IUnitOfWork unitOfWork)
        {
            Check.NotNull(unitOfWork, "unitOfWork");
            _unitOfWork = unitOfWork;
        }

        public IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return _unitOfWork.Set<TEntity>();
        }

        public int SaveChanges()
        {
            return _unitOfWork.SaveChanges();
        }

        public void Dispose()
        {
            _unitOfWork.Dispose();
        }

    }
}
