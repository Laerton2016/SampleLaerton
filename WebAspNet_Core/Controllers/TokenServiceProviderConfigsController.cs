using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAspNet_Core.Context;
using WebAspNet_Core.Models;

namespace WebAspNet_Core.Controllers
{
    public class TokenServiceProviderConfigsController : Controller
    {
        private readonly TokenizationServiceDAOTokenVaultContext _context;

        public TokenServiceProviderConfigsController(TokenizationServiceDAOTokenVaultContext context)
        {
            _context = context;
        }

        // GET: TokenServiceProviderConfigs
        public async Task<IActionResult> Index()
        {
            return View(await _context.TokenServiceProviderConfig.ToListAsync());
        }

        // GET: TokenServiceProviderConfigs/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tokenServiceProviderConfig = await _context.TokenServiceProviderConfig
                .FirstOrDefaultAsync(m => m.TokenServiceProviderCode == id);
            if (tokenServiceProviderConfig == null)
            {
                return NotFound();
            }

            return View(tokenServiceProviderConfig);
        }

        // GET: TokenServiceProviderConfigs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TokenServiceProviderConfigs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TokenServiceProviderCode,ParametersJson")] TokenServiceProviderConfig tokenServiceProviderConfig)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tokenServiceProviderConfig);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tokenServiceProviderConfig);
        }

        // GET: TokenServiceProviderConfigs/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tokenServiceProviderConfig = await _context.TokenServiceProviderConfig.FindAsync(id);
            if (tokenServiceProviderConfig == null)
            {
                return NotFound();
            }
            return View(tokenServiceProviderConfig);
        }

        // POST: TokenServiceProviderConfigs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("TokenServiceProviderCode,ParametersJson")] TokenServiceProviderConfig tokenServiceProviderConfig)
        {
            if (id != tokenServiceProviderConfig.TokenServiceProviderCode)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tokenServiceProviderConfig);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TokenServiceProviderConfigExists(tokenServiceProviderConfig.TokenServiceProviderCode))
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
            return View(tokenServiceProviderConfig);
        }

        // GET: TokenServiceProviderConfigs/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tokenServiceProviderConfig = await _context.TokenServiceProviderConfig
                .FirstOrDefaultAsync(m => m.TokenServiceProviderCode == id);
            if (tokenServiceProviderConfig == null)
            {
                return NotFound();
            }

            return View(tokenServiceProviderConfig);
        }

        // POST: TokenServiceProviderConfigs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var tokenServiceProviderConfig = await _context.TokenServiceProviderConfig.FindAsync(id);
            _context.TokenServiceProviderConfig.Remove(tokenServiceProviderConfig);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TokenServiceProviderConfigExists(string id)
        {
            return _context.TokenServiceProviderConfig.Any(e => e.TokenServiceProviderCode == id);
        }
    }
}
