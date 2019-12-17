using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GeToque.Data;
using GeToque.Models;

namespace Estoque.Controllers
{
    public class RoupasController : Controller
    {
        private readonly GeToqueContext _context;

        public RoupasController(GeToqueContext context)
        {
            _context = context;
        }

        // GET: Roupas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Roupa.ToListAsync());
        }

        // GET: Roupas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roupa = await _context.Roupa
                .FirstOrDefaultAsync(m => m.RoupaId == id);
            if (roupa == null)
            {
                return NotFound();
            }

            return View(roupa);
        }

        // GET: Roupas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Roupas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RoupaId,Tipos,Quantidade")] Roupa roupa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(roupa);
                await _context.SaveChangesAsync();
                //return RedirectToAction(nameof(Index));
            }
            if (roupa.Quantidade == 0)
            {
                Confeccao c = new Confeccao();
                c.Horario = DateTime.Now;
                c.RoupaId = roupa.RoupaId;
                _context.Confeccao.Add(c);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Roupas");
        }

        // GET: Roupas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roupa = await _context.Roupa.FindAsync(id);
            if (roupa == null)
            {
                return NotFound();
            }
            return View(roupa);
        }

        // POST: Roupas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RoupaId,Tipos,Quantidade")] Roupa roupa)
        {
            if (id != roupa.RoupaId)
            {
                return NotFound();
            }
            if (roupa.Quantidade == 0)
            {
                Confeccao c = new Confeccao();
                c.Horario = DateTime.Now;
                c.RoupaId = roupa.RoupaId;
                _context.Confeccao.Add(c);
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(roupa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoupaExists(roupa.RoupaId))
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
            return View(roupa);
        }

        // GET: Roupas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roupa = await _context.Roupa
                .FirstOrDefaultAsync(m => m.RoupaId == id);
            if (roupa == null)
            {
                return NotFound();
            }

            return View(roupa);
        }

        // POST: Roupas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var roupa = await _context.Roupa.FindAsync(id);
            _context.Roupa.Remove(roupa);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoupaExists(int id)
        {
            return _context.Roupa.Any(e => e.RoupaId == id);
        }
    }
}
