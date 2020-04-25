using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RestaurantLaPashtetDeliverySystem.Models;

namespace RestaurantLaPashtetDeliverySystem.Controllers
{
    public class ClassificationController : Controller
    {
        private readonly AppDbContext _context;

        public ClassificationController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Classification
        public async Task<IActionResult> Index()
        {
            return View(await _context.Classifications.ToListAsync());
        }

        // GET: Classification/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classification = await _context.Classifications
                .FirstOrDefaultAsync(m => m.ClassificationId == id);
            if (classification == null)
            {
                return NotFound();
            }

            return View(classification);
        }

        // GET: Classification/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Classification/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ClassificationId,ClassificationName,Description")] Classification classification)
        {
            if (ModelState.IsValid)
            {
                _context.Add(classification);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(classification);
        }

        // GET: Classification/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classification = await _context.Classifications.FindAsync(id);
            if (classification == null)
            {
                return NotFound();
            }
            return View(classification);
        }

        // POST: Classification/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ClassificationId,ClassificationName,Description")] Classification classification)
        {
            if (id != classification.ClassificationId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(classification);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClassificationExists(classification.ClassificationId))
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
            return View(classification);
        }

        // GET: Classification/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classification = await _context.Classifications
                .FirstOrDefaultAsync(m => m.ClassificationId == id);
            if (classification == null)
            {
                return NotFound();
            }

            return View(classification);
        }

        // POST: Classification/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var classification = await _context.Classifications.FindAsync(id);
            _context.Classifications.Remove(classification);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClassificationExists(int id)
        {
            return _context.Classifications.Any(e => e.ClassificationId == id);
        }
    }
}
