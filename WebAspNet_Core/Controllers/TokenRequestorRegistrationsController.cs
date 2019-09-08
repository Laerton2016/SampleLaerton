using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAspNet_Core.Context;
using WebAspNet_Core.Models;
using WebAspNet_Core.Interface;

namespace WebAspNet_Core.Controllers
{
    public class TokenRequestorRegistrationsController : Controller
    {
        private readonly ITokenRequestorRegistrationRepository _repository;

        public TokenRequestorRegistrationsController(ITokenRequestorRegistrationRepository repository)
        {
            _repository = repository;
        }

        // GET: TokenRequestorRegistrations
        public IActionResult Index()
        {
            return View(_repository.FindAll());
        }

        // GET: TokenRequestorRegistrations/Details/5
        public IActionResult Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tokenRequestorRegistration = _repository.FindAll()
                .FirstOrDefault(m => m.TokenRequestorId == id);
            if (tokenRequestorRegistration == null)
            {
                return NotFound();
            }

            return View(tokenRequestorRegistration);
        }

        // GET: TokenRequestorRegistrations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TokenRequestorRegistrations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("TokenRequestorId,Bin,TokenBin,InitialRangeBin,FinalRangeBin,RangeCounter,LabelImkac,LabelPci,EmvkeyIndex,PcikeyIndex,DateExpirationTokenPolicy,TimeEventExpirationTokenPolicy,EventCounterMaximuPolicy,TransactionAmountMaximumPolicy")] TokenRequestorRegistration tokenRequestorRegistration)
        {
            if (ModelState.IsValid)
            {
                _repository.InsertPersistence(tokenRequestorRegistration);
                return RedirectToAction(nameof(Index));
            }
            return View(tokenRequestorRegistration);
        }

        // GET: TokenRequestorRegistrations/Edit/5
        public IActionResult Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tokenRequestorRegistration = _repository.Find(id);
            if (tokenRequestorRegistration == null)
            {
                return NotFound();
            }
            return View(tokenRequestorRegistration);
        }

        // POST: TokenRequestorRegistrations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(string id, [Bind("TokenRequestorId,Bin,TokenBin,InitialRangeBin,FinalRangeBin,RangeCounter,LabelImkac,LabelPci,EmvkeyIndex,PcikeyIndex,DateExpirationTokenPolicy,TimeEventExpirationTokenPolicy,EventCounterMaximuPolicy,TransactionAmountMaximumPolicy")] TokenRequestorRegistration tokenRequestorRegistration)
        {
            if (id != tokenRequestorRegistration.TokenRequestorId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _repository.UpdatePersistence(tokenRequestorRegistration);
                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TokenRequestorRegistrationExists(tokenRequestorRegistration.TokenRequestorId))
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
            return View(tokenRequestorRegistration);
        }

        // GET: TokenRequestorRegistrations/Delete/5
        public IActionResult Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tokenRequestorRegistration = _repository.FindAll()
                .FirstOrDefault(m => m.TokenRequestorId == id);
            if (tokenRequestorRegistration == null)
            {
                return NotFound();
            }

            return View(tokenRequestorRegistration);
        }

        // POST: TokenRequestorRegistrations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(string id)
        {
            var tokenRequestorRegistration = _repository.Find(id);
            _repository.DeletePersistence(tokenRequestorRegistration);
            return RedirectToAction(nameof(Index));
        }

        private bool TokenRequestorRegistrationExists(string id)
        {
            return _repository.FindAll().Any(e => e.TokenRequestorId == id);
        }
    }
}
