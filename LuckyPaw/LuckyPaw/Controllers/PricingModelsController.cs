using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LuckyPaw.Data;
using LuckyPaw.Models;

namespace LuckyPaw.Controllers
{
    public class PricingModelsController : Controller
    {
        private readonly LuckyPawContext _context;

        public PricingModelsController(LuckyPawContext context)
        {
            _context = context;
        }

        // GET: PricingModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.PricingModel.ToListAsync());
        }

        // GET: PricingModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pricingModel = await _context.PricingModel
                .FirstOrDefaultAsync(m => m.priceID == id);
            if (pricingModel == null)
            {
                return NotFound();
            }

            return View(pricingModel);
        }

        // GET: PricingModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PricingModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("priceID,RequestId,PriceDesc,price,image_url")] PricingModel pricingModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pricingModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pricingModel);
        }

        // GET: PricingModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pricingModel = await _context.PricingModel.FindAsync(id);
            if (pricingModel == null)
            {
                return NotFound();
            }
            return View(pricingModel);
        }

        // POST: PricingModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("priceID,RequestId,PriceDesc,price,image_url")] PricingModel pricingModel)
        {
            if (id != pricingModel.priceID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pricingModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PricingModelExists(pricingModel.priceID))
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
            return View(pricingModel);
        }

        // GET: PricingModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pricingModel = await _context.PricingModel
                .FirstOrDefaultAsync(m => m.priceID == id);
            if (pricingModel == null)
            {
                return NotFound();
            }

            return View(pricingModel);
        }

        // POST: PricingModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pricingModel = await _context.PricingModel.FindAsync(id);
            _context.PricingModel.Remove(pricingModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PricingModelExists(int id)
        {
            return _context.PricingModel.Any(e => e.priceID == id);
        }
    }
}
