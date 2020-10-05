using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TicketSystem.Data;
using TicketSystem.Models;

namespace TicketSystem.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {

        private readonly ApplicationDbContext _context;

        public DashboardController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Close(int? id)
        {
            var ticket = await _context.Tickets
               .FirstOrDefaultAsync(m => m.ID == id);

            ticket.TicketStatus = "Closed";
            var cm = _context.Claims.FirstOrDefault(t => t.TicketID == ticket.ID);
            _context.Claims.Remove(cm);

            var userID = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            ClosedModel closed = new ClosedModel();
            closed.TicketId = ticket.ID;
            closed.ClosedId = userID;
            closed.DateClosed = DateTime.Now;

            _context.Add(closed);
            await _context.SaveChangesAsync();

            //remove ticket from claimed table
            // should we have a closed table?

            //update ticket stats.

            return RedirectToAction(nameof(Index));

            return View();
        }

        public async Task<IActionResult> TicketDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticket = await _context.Tickets
                .FirstOrDefaultAsync(m => m.ID == id);
            if (ticket == null)
            {
                return NotFound();
            }

            return View(ticket);
        }

        public async Task<IActionResult> Users()
        {
            var users = await _context.Users.ToListAsync();

            return View(users);
        }

        public async Task<IActionResult> AdminPanel()
        {
            string userID = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var claimedTickets = await _context.Claims.ToListAsync();

            claimedTickets = claimedTickets.FindAll(t => t.UserId == userID);

            List<Ticket> ticket = new List<Ticket>();

            foreach (ClaimedModel item in claimedTickets)
            {
                ticket.Add(_context.Tickets.FirstOrDefault(t => t.ID == item.TicketID));
            }

            return View(ticket);
        }
        public async Task<IActionResult> Index()
        {
            string userID = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var claimedTickets = await _context.Claims.ToListAsync();

            claimedTickets = claimedTickets.FindAll(t => t.UserId == userID);

            List<Ticket> ticket = new List<Ticket>();

            foreach (ClaimedModel item in claimedTickets)
            {
                ticket.Add(_context.Tickets.FirstOrDefault(t => t.ID == item.TicketID));
            }

            return View(ticket);
        }
    }
}
