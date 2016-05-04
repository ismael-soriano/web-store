using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public interface IDbBase
    {
        IDbSet<TEntity> Set<TEntity>() where TEntity : class;
    }
}
