using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TicketSystem.Models;

namespace TicketSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<ClaimedModel> Claims { get; set; }
        public DbSet<ClosedModel> Closed { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
