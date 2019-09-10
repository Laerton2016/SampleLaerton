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
using WebAspNet_Core.Repository;

namespace WebAspNet_Core.Controllers
{
    public class MappingLgpdtokensController : Controller
    {
        private readonly IMappingLgpdtokenRepository _repository;
        private readonly ITokenRequestorRegistrationRepository _tr;
        private readonly IUnitOfWork _unitOfWork;

        public MappingLgpdtokensController(IUnitOfWork unitOfWork, TokenizationServiceDAOTokenVaultContext context )
        {
            _unitOfWork = unitOfWork;
            _repository = new MappingLgpdtokenRepository(_unitOfWork, context);
            _tr = new TokenRequestorRegistrationRepository(_unitOfWork, context);
        }

        // GET: MappingLgpdtokens
        public IActionResult Index()
        {
            var tokenizationServiceDAOTokenVaultContext = _repository.FindAll();
            return View(tokenizationServiceDAOTokenVaultContext);
        }

        
        public IActionResult Details(string id, string id2)
        {
            if (id == null || id2 == null)
            {
                return NotFound();
            }

            var mappingLgpdtoken = _repository.FindAll()
                .FirstOrDefault(m => m.TokenRequestorId == id && m.TokenReferenceId == id2);
            if (mappingLgpdtoken == null)
            {
                return NotFound();
            }

            return View(mappingLgpdtoken);
        }

        // GET: MappingLgpdtokens/Create
        public IActionResult Create()
        {

            ViewData["TokenRequestorId"] = new SelectList(_tr.FindAll(), "TokenRequestorId", "TokenRequestorId");
            return View();
        }

        // POST: MappingLgpdtokens/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("TokenRequestorId,TokenReferenceId,Bin,Cpflength,Cpfciphered,LgpdtokenLength,Lgpdtoken,RangeCounter,TokenReferenceIdlength,TokenExpirationDate,EventCounter,TimerEventExpiration,Last4DigitsPan,CodeValidation,TokenLocation,PcikeyIndex,CardHolderDataCiphered")] MappingLgpdtoken mappingLgpdtoken)
        {
            if (ModelState.IsValid)
            {
                //_repository.InsertPersistence(mappingLgpdtoken);
                _repository.Add(mappingLgpdtoken); 
                _unitOfWork.Commit();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TokenRequestorId"] = new SelectList(_repository.FindAll(), "TokenRequestorId", "TokenRequestorId", mappingLgpdtoken.TokenRequestorId);
            return View(mappingLgpdtoken);
        }

        
        public IActionResult Edit(string id, string id2)
        {
            if (id == null ||id2 == null)
            {
                return NotFound();
            }

            var mappingLgpdtoken = _repository.Find(id, id2);
            if (mappingLgpdtoken == null)
            {
                return NotFound();
            }
            ViewData["TokenRequestorId"] = new SelectList(_repository.FindAll(), "TokenRequestorId", "TokenRequestorId", mappingLgpdtoken.TokenRequestorId);
            return View(mappingLgpdtoken);
        }

        // POST: MappingLgpdtokens/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public IActionResult EditDados(string id, [Bind("TokenRequestorId,TokenReferenceId,Bin,Cpflength,Cpfciphered,LgpdtokenLength,Lgpdtoken,RangeCounter,TokenReferenceIdlength,TokenExpirationDate,EventCounter,TimerEventExpiration,Last4DigitsPan,CodeValidation,TokenLocation,PcikeyIndex,CardHolderDataCiphered")] MappingLgpdtoken mappingLgpdtoken)
        {
            if (id != mappingLgpdtoken.TokenRequestorId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    //_repository.UpdatePersistence(mappingLgpdtoken);
                    _repository.Update(mappingLgpdtoken);
                    _unitOfWork.Commit();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MappingLgpdtokenExists(mappingLgpdtoken.TokenReferenceId, mappingLgpdtoken.TokenRequestorId))
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
            ViewData["TokenRequestorId"] = new SelectList(_repository.FindAll(), "TokenRequestorId", "TokenRequestorId", mappingLgpdtoken.TokenRequestorId);
            return View(mappingLgpdtoken);
        }

        
        public IActionResult Delete(string id, string id2)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mappingLgpdtoken = _repository.FindAll()
                .FirstOrDefault(m => m.TokenRequestorId == id && m.TokenReferenceId == id2);
            if (mappingLgpdtoken == null)
            {
                return NotFound();
            }

            return View(mappingLgpdtoken);
        }

        
        public IActionResult DeleteConfirmed(string id , string id2)
        {
            var mappingLgpdtoken =_repository.Find(id, id2);
            //_repository.DeletePersistence(mappingLgpdtoken);
            _repository.Remove(mappingLgpdtoken);
            _unitOfWork.Commit();
            
            return RedirectToAction(nameof(Index));
        }

        private bool MappingLgpdtokenExists(string id, string id2)
        {
            return _repository.FindAll().Any(e => e.TokenRequestorId == id && e.TokenReferenceId == id2);
        }
    }
}
