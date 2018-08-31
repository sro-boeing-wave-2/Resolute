using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ticket_management.Models
{
    public class TicketCount
    {
        int total;
        int open;
        int closed;
        int due;

        public int Total { get => total; set => total = value; }
        public int Open { get => open; set => open = value; }
        public int Closed { get => closed; set => closed = value; }
        public int Due { get => due; set => due = value; }
    }
}
