using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Ticket : EntityBase
    {
        public Ticket()
        {
            Operations = new HashSet<TicketDetail>();
        }

        [Required]
        public DateTime Date { get; set; }
        public virtual ICollection<TicketDetail> Operations { get; set; }
    }
}
