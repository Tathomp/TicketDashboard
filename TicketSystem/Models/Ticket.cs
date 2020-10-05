using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TicketSystem.Models
{
    

    public class Ticket
    {
        [Key]
        public int ID { get; set; }
        public string CreatedById { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string TicketStatus { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }
    }
}
