using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSystem.Models
{
    public class UserStatsModel
    {
        public string Name { get; set; }
        public int Claimed { get; set; }
        public int Closed { get; set; }
        public UserStatsModel(string name, int claimed, int closed)
        {
            this.Name = name;
            this.Claimed = claimed;
            this.Closed = closed;
        }
    }
}
