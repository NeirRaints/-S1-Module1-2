using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ClinicBigBoarsWeb.Data;
using ClinicBigBoarsWeb.Models;

namespace ClinicBigBoarsWeb.Controllers
{
    public class HospitalizationsController : Controller
    {
        private readonly ClinicBigBoarsWebContext _context;

        public HospitalizationsController(ClinicBigBoarsWebContext context)
        {
            _context = context;
        }

        // GET: Hospitalizations
        public async Task<IActionResult> Index()
        {
            return View(await _context.Hospitalization.ToListAsync());
        }

        // GET: Hospitalizations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hospitalization = await _context.Hospitalization
                .FirstOrDefaultAsync(m => m.HospitalizationId == id);
            if (hospitalization == null)
            {
                return NotFound();
            }

            return View(hospitalization);
        }

        // GET: Hospitalizations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Hospitalizations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HospitalizationId,PatientId,HospitalizationCode,AppointedDate,HospitalizationObj,Department,Conditions,DeadlineDate,Additionally")] Hospitalization hospitalization)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hospitalization);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hospitalization);
        }

        // GET: Hospitalizations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hospitalization = await _context.Hospitalization.FindAsync(id);
            if (hospitalization == null)
            {
                return NotFound();
            }
            return View(hospitalization);
        }

        // POST: Hospitalizations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("HospitalizationId,PatientId,HospitalizationCode,AppointedDate,HospitalizationObj,Department,Conditions,DeadlineDate,Additionally")] Hospitalization hospitalization)
        {
            if (id != hospitalization.HospitalizationId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hospitalization);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HospitalizationExists(hospitalization.HospitalizationId))
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
            return View(hospitalization);
        }

        // GET: Hospitalizations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hospitalization = await _context.Hospitalization
                .FirstOrDefaultAsync(m => m.HospitalizationId == id);
            if (hospitalization == null)
            {
                return NotFound();
            }

            return View(hospitalization);
        }

        // POST: Hospitalizations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hospitalization = await _context.Hospitalization.FindAsync(id);
            if (hospitalization != null)
            {
                _context.Hospitalization.Remove(hospitalization);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HospitalizationExists(int id)
        {
            return _context.Hospitalization.Any(e => e.HospitalizationId == id);
        }
    }
}
