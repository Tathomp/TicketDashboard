using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TicketSystem.Data;

namespace TicketSystem.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        public UsersController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
           var users = await _context.Users.ToListAsync();

           return View(users);
            
        }

        // GET: Tickets/Edit/5
        public async Task<IActionResult> Edit(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticket = await _context.Users.FindAsync(id);
            if (ticket == null)
            {
                return NotFound();
            }


            return View(ticket);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,UserName,Email")] IdentityUser model)
        {
            if (id != model.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(model);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                   if (!IfUserExists(model.Id))
                   {
                        return NotFound();
                   }
                   else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(id);
        }

        private bool IfUserExists(string id)
        {

            return _context.Users.Any(e => e.Id == id);
        }
    }


}
