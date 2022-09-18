using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projeto_Imobiliaria.DBContext;
using Projeto_Imobiliaria.Models;

namespace Projeto_Imobiliaria.Controllers
{
    public class ImoveisController : Controller
    {
        private readonly ImovelContext _context;

        public ImoveisController(ImovelContext context)
        {
            _context = context;
        }

        // GET: Imoveis
        public async Task<IActionResult> Index()
        {
              return View(await _context.Imovel.ToListAsync());
        }

        // GET: Imoveis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Imovel == null)
            {
                return NotFound();
            }

            var imovel = await _context.Imovel
                .FirstOrDefaultAsync(m => m.ID == id);
            if (imovel == null)
            {
                return NotFound();
            }

            return View(imovel);
        }

        // GET: Imoveis/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Imoveis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,CEP,Logradouro,Numero,Bairro,Cidade,Estado,PrecoVenda,PrecoCaucao")] Imovel imovel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(imovel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(imovel);
        }

        // GET: Imoveis/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Imovel == null)
            {
                return NotFound();
            }

            var imovel = await _context.Imovel.FindAsync(id);
            if (imovel == null)
            {
                return NotFound();
            }
            return View(imovel);
        }

        // POST: Imoveis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,CEP,Logradouro,Numero,Bairro,Cidade,Estado,PrecoVenda,PrecoCaucao")] Imovel imovel)
        {
            if (id != imovel.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(imovel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ImovelExists(imovel.ID))
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
            return View(imovel);
        }

        // GET: Imoveis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Imovel == null)
            {
                return NotFound();
            }

            var imovel = await _context.Imovel
                .FirstOrDefaultAsync(m => m.ID == id);
            if (imovel == null)
            {
                return NotFound();
            }

            return View(imovel);
        }

        // POST: Imoveis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Imovel == null)
            {
                return Problem("Entity set 'ImovelContext.Imovel'  is null.");
            }
            var imovel = await _context.Imovel.FindAsync(id);
            if (imovel != null)
            {
                _context.Imovel.Remove(imovel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ImovelExists(int id)
        {
          return _context.Imovel.Any(e => e.ID == id);
        }
    }
}
