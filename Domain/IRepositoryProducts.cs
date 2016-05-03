using System.Data.Entity;

namespace Domain
{
    public interface IRepositoryProducts : IUnitOfWork
    {
        IDbSet<Product> Products { get; set; }
    }
}
