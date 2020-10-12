using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TicketSystem.Data;
using TicketSystem.Models;

namespace TicketSystem.Controllers
{
    [Authorize(Roles = "Admin")]
    public class StatisticsController : Controller
    {

        private readonly ApplicationDbContext _context;

        public StatisticsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<IdentityUser> users = await _context.Users.ToListAsync();



            ViewData["users"] = users;


            
            return View();
        }

        public async Task<IActionResult> UserStats(string? id)
        {
            var user = await _context.Users.FindAsync(id);
            var claimed = await _context.Claims.ToListAsync();
            var closed = await _context.Closed.ToListAsync();

            int claimCount = claimed.FindAll(c => c.UserId == id).Count;
            int closeCount = closed.FindAll(c => c.ClosedId == id).Count;

            UserStatsModel model = new UserStatsModel(user.UserName, claimCount, closeCount);

            return View(model);
        }
    }


}
