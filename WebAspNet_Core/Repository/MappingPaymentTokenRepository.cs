using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAspNet_Core.Context;
using WebAspNet_Core.Interface;
using WebAspNet_Core.Models;

namespace WebAspNet_Core.Repository
{
    public class MappingPaymentTokenRepository : IMappingPaymentTokenRepository
    {
        private IUnitOfWork _unitOfWork;
        private readonly TokenizationServiceDAOTokenVaultContext _context;

        public MappingPaymentTokenRepository(IUnitOfWork unitOfWork , TokenizationServiceDAOTokenVaultContext context)
        {
            _unitOfWork = unitOfWork;
            _context = context;
        }

        public void Add(MappingPaymentToken mapping)
        {
            _unitOfWork.RegistraAdd(mapping, this);
        }

        public void DeletePersistence(IPersistenceBase entidade)
        {
            _context.MappingPaymentToken.Remove((MappingPaymentToken) entidade);
            _context.SaveChanges();
        }

        public IList<MappingPaymentToken> FindAll()
        {
            return _context.MappingPaymentToken.Include(m => m.TokenRequestor).ToList();
        }

        public MappingPaymentToken Find (string TokenReferenceId, string TokenRequestorId)
        {
            var result = _context.MappingPaymentToken.Where(c => c.TokenReferenceId == TokenReferenceId && c.TokenRequestorId == TokenRequestorId).ToList();
            return result.Count >0 ? result[0]: null;
        }

        public void InsertPersistence(IPersistenceBase entidade)
        {
            _context.MappingPaymentToken.Add((MappingPaymentToken)entidade);
            _context.SaveChanges();
        }

        public void Remove(MappingPaymentToken mapping)
        {
            _unitOfWork.RegistraRemove(mapping, this);
        }

        public void Update(MappingPaymentToken mapping)
        {
            _unitOfWork.RegistraUpdate(mapping, this);
        }

        public void UpdatePersistence(IPersistenceBase entidade)
        {
            MappingPaymentToken mpt = (MappingPaymentToken)entidade;
            _context.Attach(mpt);
            _context.Entry(mpt).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
