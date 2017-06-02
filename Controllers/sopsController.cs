using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NETCOperations.Data;
using NETCOperations.Models.OpsViewModels;
using System.IO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.CodeAnalysis;
using Microsoft.DotNet.ProjectModel;
using Microsoft.Net.Http.Headers;


namespace NETCOperations.Controllers
{
    [RequireHttps]
    [Authorize]
    public class sopsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private IHostingEnvironment hostingEnv;

        public sopsController(ApplicationDbContext context, IHostingEnvironment env)
        {
            _context = context;
            this.hostingEnv = env;
        }

        

        // GET: sops
        public async Task<IActionResult> Index(string searchString)
        {
            var hostName = from h in _context.sop select h;
            hostName = hostName.OrderBy(h => h.Name);
            if (!string.IsNullOrEmpty(searchString))
            {
                hostName = hostName.Where(h => h.Description.Contains(searchString));
            }
            return View(await hostName.ToListAsync());
        }


        // GET: sops/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: sops/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(sop model, IList<IFormFile> files)
        {
            if (ModelState.IsValid)
            {
                long size = 0;
                var document = new sop { Name = model.Name, Edited = DateTime.UtcNow, Description = model.Description,
                    shortDescription = model.shortDescription, Location = ""};
                var stupidfile = "";
                foreach (var file in files)
                {
                    var fileName = ContentDispositionHeaderValue
                        .Parse(file.ContentDisposition)
                        .FileName
                        .Trim('"');
                    string fwe = Path.GetFileName(fileName);
                    string ext = Path.GetExtension(fileName);
                    fwe = document.Name;
                    fileName = Path.Combine(hostingEnv.WebRootPath, "sop", fwe + ext);
                    size += file.Length;
                    stupidfile = Path.Combine($"sop/{fwe+ext}");
                    using (FileStream fs = System.IO.File.Create(fileName))
                    {
                        file.CopyTo(fs);
                        fs.Flush();
                    }
                }
                document.Location = stupidfile;
                _context.Add(document);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View("Index");
        }

        

        // GET: sops/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sop = await _context.sop.SingleOrDefaultAsync(m => m.Id == id);
            if (sop == null)
            {
                return NotFound();
            }

            return View(sop);
        }

        // POST: sops/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sop = await _context.sop.SingleOrDefaultAsync(m => m.Id == id);
            var file = Path.Combine(hostingEnv.WebRootPath, sop.Location);
            System.IO.File.Delete(file);
            _context.sop.Remove(sop);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool sopExists(int id)
        {
            return _context.sop.Any(e => e.Id == id);
        }
    }
}
