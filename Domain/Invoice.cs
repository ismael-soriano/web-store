using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Invoice : EntityBase
    {
        public Invoice()
        {
            Operations = new List<Operation>();
        }

        [Required]
        public DateTime Date { get; set; }
        public virtual IEnumerable<Operation> Operations { get; set; }
    }
}
