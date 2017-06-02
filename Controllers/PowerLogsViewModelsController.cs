using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NETCOperations.Data;
using NETCOperations.Models.OpsViewModels;

namespace NETCOperations.Controllers
    
{
    [RequireHttps]
    [Authorize]
    public class PowerLogsViewModelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PowerLogsViewModelsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: PowerLogsViewModels
        public async Task<IActionResult> Index(string searchString)
        {
            var day = from h in _context.PowerLogsViewModel select h;
            day = day.OrderByDescending(h => h.Date);
            
            if (!string.IsNullOrEmpty(searchString))
            {
                day = day.Where(h => h.Date.ToString().Contains(searchString));
            }
            return View(await day.ToListAsync());
        }

        // GET: PowerLogsViewModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var powerLogsViewModel = await _context.PowerLogsViewModel.SingleOrDefaultAsync(m => m.ID == id);
            if (powerLogsViewModel == null)
            {
                return NotFound();
            }

            return View(powerLogsViewModel);
        }

        // GET: PowerLogsViewModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PowerLogsViewModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,A,B,C,Date,Day,Kw,kva,pf,ups")] PowerLogsViewModel powerLogsViewModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(powerLogsViewModel);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(powerLogsViewModel);
        }

        // GET: PowerLogsViewModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var powerLogsViewModel = await _context.PowerLogsViewModel.SingleOrDefaultAsync(m => m.ID == id);
            if (powerLogsViewModel == null)
            {
                return NotFound();
            }
            return View(powerLogsViewModel);
        }

        // POST: PowerLogsViewModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,A,B,C,Date,Day,Kw,kva,pf,ups")] PowerLogsViewModel powerLogsViewModel)
        {
            if (id != powerLogsViewModel.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(powerLogsViewModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PowerLogsViewModelExists(powerLogsViewModel.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(powerLogsViewModel);
        }

        // GET: PowerLogsViewModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var powerLogsViewModel = await _context.PowerLogsViewModel.SingleOrDefaultAsync(m => m.ID == id);
            if (powerLogsViewModel == null)
            {
                return NotFound();
            }

            return View(powerLogsViewModel);
        }

        // POST: PowerLogsViewModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var powerLogsViewModel = await _context.PowerLogsViewModel.SingleOrDefaultAsync(m => m.ID == id);
            _context.PowerLogsViewModel.Remove(powerLogsViewModel);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool PowerLogsViewModelExists(int id)
        {
            return _context.PowerLogsViewModel.Any(e => e.ID == id);
        }
    }
}
