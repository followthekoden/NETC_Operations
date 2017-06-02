using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NETCOperations.Data;
using NETCOperations.Models.OpsViewModels;

namespace NETCOperations.Controllers
{
    public class callbackModelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public callbackModelsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: callbackModels
        public async Task<IActionResult> Index(string searchString)
        {
            var people = from p in _context.callbackModel select p;
            people = people.OrderBy(p => p.Name);
            if (!string.IsNullOrEmpty(searchString))
            {
                people = people.Where(h => h.Name.Contains(searchString));
            }
            return View(await people.ToListAsync());
        }

        // GET: callbackModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var callbackModel = await _context.callbackModel.SingleOrDefaultAsync(m => m.Id == id);
            if (callbackModel == null)
            {
                return NotFound();
            }

            return View(callbackModel);
        }

        // GET: callbackModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: callbackModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Group,Name,Primary,Secondary")] callbackModel callbackModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(callbackModel);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(callbackModel);
        }

        // GET: callbackModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var callbackModel = await _context.callbackModel.SingleOrDefaultAsync(m => m.Id == id);
            if (callbackModel == null)
            {
                return NotFound();
            }
            return View(callbackModel);
        }

        // POST: callbackModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Group,Name,Primary,Secondary")] callbackModel callbackModel)
        {
            if (id != callbackModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(callbackModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!callbackModelExists(callbackModel.Id))
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
            return View(callbackModel);
        }

        // GET: callbackModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var callbackModel = await _context.callbackModel.SingleOrDefaultAsync(m => m.Id == id);
            if (callbackModel == null)
            {
                return NotFound();
            }

            return View(callbackModel);
        }

        // POST: callbackModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var callbackModel = await _context.callbackModel.SingleOrDefaultAsync(m => m.Id == id);
            _context.callbackModel.Remove(callbackModel);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool callbackModelExists(int id)
        {
            return _context.callbackModel.Any(e => e.Id == id);
        }
    }
}
