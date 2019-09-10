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
    public class MappingPaymentTokensController : Controller
    {
        private readonly IMappingPaymentTokenRepository _repository;
        private readonly ITokenRequestorRegistrationRepository _tr;
        private readonly IUnitOfWork _unitOfWork;

        public MappingPaymentTokensController(IUnitOfWork unitOfWork, TokenizationServiceDAOTokenVaultContext context)
        {
            _unitOfWork = unitOfWork;
            _repository = new MappingPaymentTokenRepository(_unitOfWork, context);
            _tr = new TokenRequestorRegistrationRepository(_unitOfWork, context);
        }

        // GET: MappingPaymentTokens
        public IActionResult Index()
        {
            var tokenizationServiceDAOTokenVaultContext = _repository.FindAll();
            return View( tokenizationServiceDAOTokenVaultContext);
        }

        // GET: MappingPaymentTokens/Details/5
        public IActionResult Details(string id, string id2)
        {
            if (id == null || id2 == null)
            {
                return NotFound();
            }

            var mappingPaymentToken = _repository.FindAll()                
                .FirstOrDefault(m => m.TokenReferenceId == id && m.TokenRequestorId == id2);
            if (mappingPaymentToken == null)
            {
                return NotFound();
            }

            return View(mappingPaymentToken);
        }

        // GET: MappingPaymentTokens/Create
        public IActionResult Create()
        {
            ViewData["TokenRequestorId"] = new SelectList(_tr.FindAll(), "TokenRequestorId", "TokenRequestorId");
            return View();
        }

        // POST: MappingPaymentTokens/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("TokenRequestorId,TokenReferenceId,Bin,Panlength,Panciphered,PanexpirationDateCiphered,TokenLength,PaymentToken,RangeCounter,TokenReferenceIdlength,TokenExpirationDate,Atc,EventCounter,TimerEventExpiration,Last4DigitsPan,CodeValidation,TokenLocation,EmvkeyIndex,PcikeyIndex,AccountAndCardHolderDataAndDeviceDataCiphered")] MappingPaymentToken mappingPaymentToken)
        {
            if (ModelState.IsValid)
            {
                _repository.Add(mappingPaymentToken);
                _unitOfWork.Commit();
                
                return RedirectToAction(nameof(Index));
            }
            ViewData["TokenRequestorId"] = new SelectList(_tr.FindAll(), "TokenRequestorId", "TokenRequestorId", mappingPaymentToken.TokenRequestorId);
            return View(mappingPaymentToken);
        }

        
        public IActionResult Edit(string id, string id2)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mappingPaymentToken = _repository.Find(id, id2);
            if (mappingPaymentToken == null)
            {
                return NotFound();
            }
            ViewData["TokenRequestorId"] = new SelectList(_tr.FindAll(), "TokenRequestorId", "TokenRequestorId", mappingPaymentToken.TokenRequestorId);
            return View(mappingPaymentToken);
        }

        // POST: MappingPaymentTokens/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditConfirmed(MappingPaymentToken mappingPaymentToken)
        
        {
           
            if (ModelState.IsValid)
            {
                try
                {
                    _repository.Update(mappingPaymentToken);
                    _unitOfWork.Commit();
                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MappingPaymentTokenExists(mappingPaymentToken.TokenReferenceId, mappingPaymentToken.TokenRequestorId))
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
            ViewData["TokenRequestorId"] = new SelectList(_tr.FindAll(), "TokenRequestorId", "TokenRequestorId", mappingPaymentToken.TokenRequestorId);
            return View(mappingPaymentToken);
        }

        
        public IActionResult Delete(string id , string id2)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mappingPaymentToken = _repository.FindAll()
                .FirstOrDefault(m => m.TokenRequestorId == id2 && m.TokenReferenceId == id);
            if (mappingPaymentToken == null)
            {
                return NotFound();
            }

            return View(mappingPaymentToken);
        }

        public IActionResult DeleteConfirmed(string id, string id2)
        {
            
            var mappingPaymentToken = _repository.Find(id, id2);
            _repository.Remove(mappingPaymentToken);
            _unitOfWork.Commit();
            
            return RedirectToAction(nameof(Index));
        }

        private bool MappingPaymentTokenExists(string id, string id2)
        {
            return _repository.FindAll().Any(e => e.TokenRequestorId == id2 && e.TokenReferenceId == id);
        }

        
    }
}
