using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAspNet_Core.Interface
{
    public interface IUnitOfWork
    {
        void RegistraUpdate(IPersistenceBase entidade, IUnitOfWorkRepository repository);
        void RegistraAdd(IPersistenceBase entidade, IUnitOfWorkRepository repository);
        void RegistraRemove(IPersistenceBase entidade, IUnitOfWorkRepository repository);
        
        void Commit();
    }
}
