using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ShopDbContext : DbContext, IRepositoryInvoices, IRepositoryProducts
    {
        public IDbSet<Invoice> Invoices { get; set; }
        public IDbSet<Product> Products { get; set; }
    }
}
