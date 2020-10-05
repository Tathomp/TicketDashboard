using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TicketSystem.Data;
using TicketSystem.Models;

namespace TicketSystem.Controllers
{
    [Authorize]
    //[Authorize(Roles = "Employee")]
    //[Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> TicketList()
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




        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
