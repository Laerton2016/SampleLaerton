using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAspNet_Core.Context;
using WebAspNet_Core.Interface;
using WebAspNet_Core.Models;

namespace WebAspNet_Core.Repository
{
    public class TokenRequestorRegistrationRepository : ITokenRequestorRegistrationRepository
    {
        private IUnitOfWork _unitOfWork;
        private readonly TokenizationServiceDAOTokenVaultContext _context;

        public TokenRequestorRegistrationRepository(IUnitOfWork unitOfWork, TokenizationServiceDAOTokenVaultContext context)
        {
            _unitOfWork = unitOfWork;
            _context = context;
        }

        public void Add(TokenRequestorRegistration token)
        {
            _unitOfWork.RegistraAdd(token, this);
        }

        public void DeletePersistence(IPersistenceBase entidade)
        {
            _context.TokenRequestorRegistration.Remove((TokenRequestorRegistration)entidade);
            _context.SaveChanges();
        }

        public IList<TokenRequestorRegistration> FindAll()
        {
            return _context.TokenRequestorRegistration.ToList();
        }

        public void InsertPersistence(IPersistenceBase entidade)
        {
            _context.TokenRequestorRegistration.Add((TokenRequestorRegistration)entidade);
            _context.SaveChanges();
        }

        public void Remove(TokenRequestorRegistration token)
        {
            _unitOfWork.RegistraRemove(token, this);
        }

        public void Update(TokenRequestorRegistration token)
        {
            _unitOfWork.RegistraUpdate(token, this);
        }

        public void UpdatePersistence(IPersistenceBase entidade)
        {
            TokenRequestorRegistration token = (TokenRequestorRegistration)entidade;
            _context.Attach(token);
            _context.Entry(token).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }

        public TokenRequestorRegistration Find(string id)
        {
            return  _context.TokenRequestorRegistration.Find(id);
        }
    }
}
