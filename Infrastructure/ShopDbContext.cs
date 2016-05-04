using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext() : base("DefaultConection"){}

        public IDbSet<Ticket> Invoices { get; set; }
        public IDbSet<Product> Products { get; set; }
    }
}
