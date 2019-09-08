using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebAspNet_Core.Interface
{
    public interface IUnitOfWorkRepository
    {
        void InsertPersistence(IPersistenceBase entidade);
        void UpdatePersistence(IPersistenceBase entidade);
        void DeletePersistence(IPersistenceBase entidade);
        
    }
}
