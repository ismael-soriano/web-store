using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Invoice
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
