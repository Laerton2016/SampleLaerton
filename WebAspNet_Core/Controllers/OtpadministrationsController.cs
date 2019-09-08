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
    public class OtpadministrationsController : Controller
    {
        private readonly IOtpadministrationRepository _repository;

        public OtpadministrationsController(IOtpadministrationRepository repository)
        {
            _repository = repository;
        }

        
        public  IActionResult Index()
        {
            return View(_repository.FindAll());
        }

        
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var otpadministration = _repository.FindAll()
                .FirstOrDefault(m => m.OtpadmId == id);
            if (otpadministration == null)
            {
                return NotFound();
            }

            return View(otpadministration);
        }

        
        public IActionResult Create()
        {
            return View();
        }

        // POST: Otpadministrations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OtpadmId,PasswordAdm,Status,TryPinCounter,LastDateLogin,LastDateBlocked,LastDateChangePin")] Otpadministration otpadministration)
        {
            if (ModelState.IsValid)
            {
                _repository.InsertPersistence(otpadministration);
                return RedirectToAction(nameof(Index));
            }
            return View(otpadministration);
        }

        // GET: Otpadministrations/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var otpadministration =  _repository.Find(id);
            if (otpadministration == null)
            {
                return NotFound();
            }
            return View(otpadministration);
        }

        // POST: Otpadministrations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("OtpadmId,PasswordAdm,Status,TryPinCounter,LastDateLogin,LastDateBlocked,LastDateChangePin")] Otpadministration otpadministration)
        {
            if (id != otpadministration.OtpadmId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _repository.UpdatePersistence(otpadministration);
                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OtpadministrationExists(otpadministration.OtpadmId))
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
            return View(otpadministration);
        }

        // GET: Otpadministrations/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var otpadministration = _repository.FindAll()
                .FirstOrDefault(m => m.OtpadmId == id);
            if (otpadministration == null)
            {
                return NotFound();
            }
            
            return View(otpadministration);
        }

        // POST: Otpadministrations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var otpadministration = _repository.Find(id);
            _repository.DeletePersistence(otpadministration);
            return RedirectToAction(nameof(Index));
        }

        private bool OtpadministrationExists(string id)
        {
            return _repository.FindAll().Any(e => e.OtpadmId == id);
        }
    }
}
