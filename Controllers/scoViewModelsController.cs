using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using NETCOperations.Data;
using NETCOperations.Models.OpsViewModels;

namespace NETCOperations.Controllers
{
    [RequireHttps]
    [Authorize]
    public class scoViewModelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public scoViewModelsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: scoViewModels
        public async Task<IActionResult> Index(string searchString)
        {
            var hostName = from h in _context.scoViewModel select h;
            hostName = hostName.OrderBy(h => h.HostName);
            if (!string.IsNullOrEmpty(searchString))
            {
                hostName = hostName.Where(h => h.HostName.Contains(searchString));
            }
            return View(await hostName.ToListAsync());
        }

        // GET: scoViewModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scoViewModel = await _context.scoViewModel.SingleOrDefaultAsync(m => m.ID == id);
            if (scoViewModel == null)
            {
                return NotFound();
            }

            return View(scoViewModel);
        }

        // GET: scoViewModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: scoViewModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,APocPrimary,APocSecondary,AfterHourCallback,HostName,Location,OSPocPrimary,OSPocSecondary,dbaadmin")] scoViewModel scoViewModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(scoViewModel);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(scoViewModel);
        }

        // GET: scoViewModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scoViewModel = await _context.scoViewModel.SingleOrDefaultAsync(m => m.ID == id);
            if (scoViewModel == null)
            {
                return NotFound();
            }
            return View(scoViewModel);
        }

        // POST: scoViewModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,APocPrimary,APocSecondary,AfterHourCallback,HostName,Location,OSPocPrimary,OSPocSecondary,dbaadmin")] scoViewModel scoViewModel)
        {
            if (id != scoViewModel.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(scoViewModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!scoViewModelExists(scoViewModel.ID))
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
            return View(scoViewModel);
        }

        // GET: scoViewModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scoViewModel = await _context.scoViewModel.SingleOrDefaultAsync(m => m.ID == id);
            if (scoViewModel == null)
            {
                return NotFound();
            }

            return View(scoViewModel);
        }

        // POST: scoViewModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var scoViewModel = await _context.scoViewModel.SingleOrDefaultAsync(m => m.ID == id);
            _context.scoViewModel.Remove(scoViewModel);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool scoViewModelExists(int id)
        {
            return _context.scoViewModel.Any(e => e.ID == id);
        }
    }
}
