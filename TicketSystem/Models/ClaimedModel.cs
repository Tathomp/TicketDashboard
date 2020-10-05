using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TicketSystem.Models
{
    public class ClaimedModel 
    {
        [Key]
        public int Id { get; set; }
       public string UserId { get; set; }
       public int TicketID { get; set; }

        public DateTime DateClaimed { get; set; }

    }
}
