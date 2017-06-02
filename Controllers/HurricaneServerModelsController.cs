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
    public class HurricaneServerModelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HurricaneServerModelsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: HurricaneServerModels
        public async Task<IActionResult> Index(string searchString)
        {
            var server = from s in _context.HurricaneServerModel select s;
            server = server.OrderBy(s => s.HostName);

            if (!string.IsNullOrEmpty(searchString))
            {
                server = server.Where(h => h.HostName.ToString().Contains(searchString));
            }
            return View(await server.ToListAsync());
        }

        // GET: HurricaneServerModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hurricaneServerModel = await _context.HurricaneServerModel.SingleOrDefaultAsync(m => m.Id == id);
            if (hurricaneServerModel == null)
            {
                return NotFound();
            }

            return View(hurricaneServerModel);
        }

        // GET: HurricaneServerModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HurricaneServerModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Application,Bldg,Enviroment,HostName,Hurricane,Location,Primary,Purpose,Rack,Room,Secondary")] HurricaneServerModel hurricaneServerModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hurricaneServerModel);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(hurricaneServerModel);
        }

        // GET: HurricaneServerModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hurricaneServerModel = await _context.HurricaneServerModel.SingleOrDefaultAsync(m => m.Id == id);
            if (hurricaneServerModel == null)
            {
                return NotFound();
            }
            return View(hurricaneServerModel);
        }

        // POST: HurricaneServerModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Application,Bldg,Enviroment,HostName,Hurricane,Location,Primary,Purpose,Rack,Room,Secondary")] HurricaneServerModel hurricaneServerModel)
        {
            if (id != hurricaneServerModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hurricaneServerModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HurricaneServerModelExists(hurricaneServerModel.Id))
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
            return View(hurricaneServerModel);
        }

        // GET: HurricaneServerModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hurricaneServerModel = await _context.HurricaneServerModel.SingleOrDefaultAsync(m => m.Id == id);
            if (hurricaneServerModel == null)
            {
                return NotFound();
            }

            return View(hurricaneServerModel);
        }

        // POST: HurricaneServerModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hurricaneServerModel = await _context.HurricaneServerModel.SingleOrDefaultAsync(m => m.Id == id);
            _context.HurricaneServerModel.Remove(hurricaneServerModel);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool HurricaneServerModelExists(int id)
        {
            return _context.HurricaneServerModel.Any(e => e.Id == id);
        }
    }
}
