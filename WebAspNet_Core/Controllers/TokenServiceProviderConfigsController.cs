using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAspNet_Core.Context;
using WebAspNet_Core.Interface;
using WebAspNet_Core.Models;
using WebAspNet_Core.Repository;

namespace WebAspNet_Core.Controllers
{
    public class TokenServiceProviderConfigsController : Controller
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly ITokenServiceProviderConfigRepository _repository;
        public TokenServiceProviderConfigsController(IUnitOfWork unitOfWork, TokenizationServiceDAOTokenVaultContext context)
        {
            _unitOfWork = unitOfWork;
            _repository = new TokenServiceProviderConfigRepository(_unitOfWork, context);
        }

        // GET: TokenServiceProviderConfigs
        public  IActionResult Index()
        {
            return View( _repository.FindAll());
        }

        // GET: TokenServiceProviderConfigs/Details/5
        public IActionResult Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tokenServiceProviderConfig = _repository.FindAll().FirstOrDefault
                (m => m.TokenServiceProviderCode == id);
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
        public IActionResult Create([Bind("TokenServiceProviderCode,ParametersJson")] TokenServiceProviderConfig tokenServiceProviderConfig)
        {
            if (ModelState.IsValid)
            {
                _repository.Add(tokenServiceProviderConfig);
                _unitOfWork.Commit();
                return RedirectToAction(nameof(Index));
            }
            return View(tokenServiceProviderConfig);
        }

        // GET: TokenServiceProviderConfigs/Edit/5
        public IActionResult Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tokenServiceProviderConfig = _repository.Find(id);
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
        public IActionResult Edit(string id, [Bind("TokenServiceProviderCode,ParametersJson")] TokenServiceProviderConfig tokenServiceProviderConfig)
        {
            if (id != tokenServiceProviderConfig.TokenServiceProviderCode)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _repository.Update(tokenServiceProviderConfig);
                    _unitOfWork.Commit();
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
        public  IActionResult Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tokenServiceProviderConfig = _repository.FindAll().FirstOrDefault
                (m => m.TokenServiceProviderCode == id);
            if (tokenServiceProviderConfig == null)
            {
                return NotFound();
            }

            return View(tokenServiceProviderConfig);
        }

        // POST: TokenServiceProviderConfigs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(string id)
        {
            var tokenServiceProviderConfig = _repository.Find(id);
            _repository.Remove(tokenServiceProviderConfig);
            _unitOfWork.Commit();
            return RedirectToAction(nameof(Index));
        }

        private bool TokenServiceProviderConfigExists(string id)
        {
            return _repository.FindAll().Any(e => e.TokenServiceProviderCode == id);
        }
    }
}
