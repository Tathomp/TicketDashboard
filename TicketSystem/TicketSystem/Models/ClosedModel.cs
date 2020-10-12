using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSystem.Models
{
    public class ClosedModel
    {
        [Key]
        public int Id { get; set; }
        public int TicketId { get; set; }
        public string ClosedId { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateClosed { get; set; }
    }
}
