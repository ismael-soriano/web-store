using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IUnitOfWork : IUnitOfWorkForService
    {
        IDbSet<TEntity> Set<TEntity>() where TEntity : class;
    }
}
