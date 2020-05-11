using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using API_REST.Data;
using Bussiness_Logic.Models;

namespace APP_WEB.Controllers
{
    public class Line_HydrocarbonController : Controller
    {
        private readonly AppDBContext _context;

        public Line_HydrocarbonController(AppDBContext context)
        {
            _context = context;
        }

        // GET: Line_Hydrocarbon
        public async Task<IActionResult> Index()
        {
            return View(await _context.Line_Hydrocarbons.ToListAsync());
        }

        // GET: Line_Hydrocarbon/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var line_Hydrocarbon = await _context.Line_Hydrocarbons
                .FirstOrDefaultAsync(m => m.Id_LineHydrocarbon == id);
            if (line_Hydrocarbon == null)
            {
                return NotFound();
            }

            return View(line_Hydrocarbon);
        }

        // GET: Line_Hydrocarbon/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Line_Hydrocarbon/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_LineHydrocarbon,Name_Line,Length_Line,Diameter_Line,InstalationDate")] Line_Hydrocarbon line_Hydrocarbon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(line_Hydrocarbon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(line_Hydrocarbon);
        }

        // GET: Line_Hydrocarbon/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var line_Hydrocarbon = await _context.Line_Hydrocarbons.FindAsync(id);
            if (line_Hydrocarbon == null)
            {
                return NotFound();
            }
            return View(line_Hydrocarbon);
        }

        // POST: Line_Hydrocarbon/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_LineHydrocarbon,Name_Line,Length_Line,Diameter_Line,InstalationDate")] Line_Hydrocarbon line_Hydrocarbon)
        {
            if (id != line_Hydrocarbon.Id_LineHydrocarbon)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(line_Hydrocarbon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Line_HydrocarbonExists(line_Hydrocarbon.Id_LineHydrocarbon))
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
            return View(line_Hydrocarbon);
        }

        // GET: Line_Hydrocarbon/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var line_Hydrocarbon = await _context.Line_Hydrocarbons
                .FirstOrDefaultAsync(m => m.Id_LineHydrocarbon == id);
            if (line_Hydrocarbon == null)
            {
                return NotFound();
            }

            return View(line_Hydrocarbon);
        }

        // POST: Line_Hydrocarbon/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var line_Hydrocarbon = await _context.Line_Hydrocarbons.FindAsync(id);
            _context.Line_Hydrocarbons.Remove(line_Hydrocarbon);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Line_HydrocarbonExists(int id)
        {
            return _context.Line_Hydrocarbons.Any(e => e.Id_LineHydrocarbon == id);
        }
    }
}
