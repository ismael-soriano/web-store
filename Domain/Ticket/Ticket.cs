using Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Ticket
{
    public class Ticket : EntityBase
    {
        public Ticket()
        {
            TicketDetails = new HashSet<TicketDetail>();
        }

        [Required]
        public DateTime Date { get; set; }
        public virtual ICollection<TicketDetail> TicketDetails { get; set; }
    }
}
