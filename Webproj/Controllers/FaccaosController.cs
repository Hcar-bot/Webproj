using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Webproj.Models;

namespace Webproj.Controllers
{
    public class FaccaosController : Controller
    {
        private readonly Contexto _context;

        public FaccaosController(Contexto context)
        {
            _context = context;
        }

        // GET: Faccaos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Faccoes.ToListAsync());
        }

        // GET: Faccaos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var faccao = await _context.Faccoes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (faccao == null)
            {
                return NotFound();
            }

            return View(faccao);
        }

        // GET: Faccaos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Faccaos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome")] Faccao faccao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(faccao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(faccao);
        }

        // GET: Faccaos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var faccao = await _context.Faccoes.FindAsync(id);
            if (faccao == null)
            {
                return NotFound();
            }
            return View(faccao);
        }

        // POST: Faccaos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome")] Faccao faccao)
        {
            if (id != faccao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(faccao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FaccaoExists(faccao.Id))
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
            return View(faccao);
        }

        // GET: Faccaos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var faccao = await _context.Faccoes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (faccao == null)
            {
                return NotFound();
            }

            return View(faccao);
        }

        // POST: Faccaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var faccao = await _context.Faccoes.FindAsync(id);
            if (faccao != null)
            {
                _context.Faccoes.Remove(faccao);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FaccaoExists(int id)
        {
            return _context.Faccoes.Any(e => e.Id == id);
        }
    }
}
