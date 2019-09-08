using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAspNet_Core.Context;
using WebAspNet_Core.Interface;
using WebAspNet_Core.Models;

namespace WebAspNet_Core.Repository
{
    public class TokenServiceProviderConfigRepository : ITokenServiceProviderConfigRepository
    {
        private IUnitOfWork _unitOfWork;
        private readonly TokenizationServiceDAOTokenVaultContext _context;

        public TokenServiceProviderConfigRepository(IUnitOfWork unitOfWork, TokenizationServiceDAOTokenVaultContext context)
        {
            _unitOfWork = unitOfWork;
            _context = context;
        }

        public void Add(TokenServiceProviderConfig token)
        {
            _unitOfWork.RegistraAdd(token, this);
        }

        public void DeletePersistence(IPersistenceBase entidade)
        {
            _context.TokenServiceProviderConfig.Remove((TokenServiceProviderConfig)entidade);
            _context.SaveChanges();
        }

        public IList<TokenServiceProviderConfig> FindAll()
        {
            return _context.TokenServiceProviderConfig.ToList();
        }

        public void InsertPersistence(IPersistenceBase entidade)
        {
            _context.TokenServiceProviderConfig.Add((TokenServiceProviderConfig)entidade);
            _context.SaveChanges();
        }

        public void Remove(TokenServiceProviderConfig token)
        {
            _unitOfWork.RegistraRemove(token, this);
        }

        public void Update(TokenServiceProviderConfig token)
        {
            _unitOfWork.RegistraUpdate(token, this);
        }

        public void UpdatePersistence(IPersistenceBase entidade)
        {
            TokenServiceProviderConfig token = (TokenServiceProviderConfig)entidade;
            _context.Attach(token);
            _context.Entry(token).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
