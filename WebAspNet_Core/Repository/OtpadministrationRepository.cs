using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAspNet_Core.Context;
using WebAspNet_Core.Interface;
using WebAspNet_Core.Models;

namespace WebAspNet_Core.Interface
{
    public class OtpadministrationRepository : IOtpadministrationRepository
    {
        private IUnitOfWork _unitOfWork;
        private readonly TokenizationServiceDAOTokenVaultContext _context;

        public OtpadministrationRepository(IUnitOfWork unitOfWork, TokenizationServiceDAOTokenVaultContext context)
        {
            _unitOfWork = unitOfWork;
            _context = context;
        }

        public void Add(Otpadministration otpadmin)
        {
            _unitOfWork.RegistraAdd(otpadmin, this);
        }

        public void DeletePersistence(IPersistenceBase entidade)
        {
            _context.Otpadministration.Remove((Otpadministration)entidade);
            _context.SaveChanges();
        }

        public IList<Otpadministration> FindAll()
        {
            return _context.Otpadministration.ToList();
        }

        public void InsertPersistence(IPersistenceBase entidade)
        {
            _context.Otpadministration.Add((Otpadministration)entidade);
            _context.SaveChanges();
        }

        public void Remove(Otpadministration otpadmin)
        {
            _unitOfWork.RegistraRemove(otpadmin, this);

        }

        public void Update(Otpadministration otpadmin)
        {
            _unitOfWork.RegistraUpdate(otpadmin, this);
        }

        public void UpdatePersistence(IPersistenceBase entidade)
        {
            Otpadministration otp = (Otpadministration)entidade;
            _context.Attach(otp);
            _context.Entry(otp).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }

        

        public Otpadministration Find(string id)
        {
            return _context.Otpadministration.Find(id);
        }
    }
}
