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
    public class MappingLgpdtokenRepository : IMappingLgpdtokenRepository
    {
        private IUnitOfWork _unitOfWork;
        private readonly TokenizationServiceDAOTokenVaultContext _context;

        public MappingLgpdtokenRepository(IUnitOfWork unitOfWork, TokenizationServiceDAOTokenVaultContext context)
        {
            _unitOfWork = unitOfWork;
            _context = context;
        }

        public void Add(MappingLgpdtoken mapping)
        {
            _unitOfWork.RegistraAdd(mapping, this);
        }

        public void DeletePersistence(IPersistenceBase entidade)
        {
            _context.MappingLgpdtoken.Remove((MappingLgpdtoken)entidade);
            _context.SaveChanges();
        }

        public IList<MappingLgpdtoken> FindAll()
        {
            return _context.MappingLgpdtoken.Include(m => m.TokenRequestor).ToList();
        }

        public void InsertPersistence(IPersistenceBase entidade)
        {
            _context.MappingLgpdtoken.Add((MappingLgpdtoken)entidade);
            _context.SaveChanges();
        }

        public void Remove(MappingLgpdtoken mapping)
        {
            _unitOfWork.RegistraRemove(mapping, this);
        }

        public void Update(MappingLgpdtoken mapping)
        {
            _unitOfWork.RegistraUpdate(mapping, this);
        }

        public void UpdatePersistence(IPersistenceBase entidade)
        {
            MappingLgpdtoken en = (MappingLgpdtoken)entidade;
            _context.Attach(en);
            _context.Entry(en).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }

        public MappingLgpdtoken Find(string id, string id2)
        {
            var result = _context.MappingLgpdtoken.Where(t => t.TokenReferenceId == id2 && t.TokenRequestorId == id).ToList();
            return result.Count == 0 ? null: result[0];
        }
    }
}
